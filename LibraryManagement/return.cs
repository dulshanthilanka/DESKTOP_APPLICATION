using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class @return : Form
    {
        public @return()
        {
            InitializeComponent();
        }

        private void return_book_return_btn_Click(object sender, EventArgs e)
        {
            // Get input values from the text fields
            int bookID;
            int memberID;
            DateTime returnDate;

            if (!int.TryParse(return_id_of_the_book_textfield.Text, out bookID))
            {
                MessageBox.Show("Invalid Book ID. Please enter a valid integer.");
                return;
            }

            if (!int.TryParse(return_book_id_of_the_member_textfield.Text, out memberID))
            {
                MessageBox.Show("Invalid Member ID. Please enter a valid integer.");
                return;
            }

            if (!DateTime.TryParse(return_id_of_the_book_textfield.Text, out returnDate))
            {
                MessageBox.Show("Invalid Date. Please enter a valid date in the correct format.");
                return;
            }

            // Replace "Your_Connection_String_Here" with your actual connection string
            string connectionString = "Data Source=THIWANKA;Initial Catalog=library;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the member has borrowed the book
                string checkBorrowQuery = "SELECT BorrowID FROM Borrow WHERE MemberID = @MemberID AND BookID = @BookID AND ReturnDate IS NULL";
                using (SqlCommand checkBorrowCmd = new SqlCommand(checkBorrowQuery, connection))
                {
                    checkBorrowCmd.Parameters.AddWithValue("@MemberID", memberID);
                    checkBorrowCmd.Parameters.AddWithValue("@BookID", bookID);

                    object borrowID = checkBorrowCmd.ExecuteScalar();

                    if (borrowID != null)
                    {
                        // Update the Borrow table with the return date
                        string returnBookQuery = "UPDATE Borrow SET ReturnDate = @ReturnDate WHERE BorrowID = @BorrowID";
                        using (SqlCommand returnBookCmd = new SqlCommand(returnBookQuery, connection))
                        {
                            returnBookCmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                            returnBookCmd.Parameters.AddWithValue("@BorrowID", borrowID);

                            returnBookCmd.ExecuteNonQuery();

                            // Update the Books table to increase the quantity and mark as available
                            string updateBookQuery = "UPDATE Books SET Quantity = Quantity + 1, IsAvailable = 1 WHERE BookID = @BookID";
                            using (SqlCommand updateBookCmd = new SqlCommand(updateBookQuery, connection))
                            {
                                updateBookCmd.Parameters.AddWithValue("@BookID", bookID);

                                updateBookCmd.ExecuteNonQuery();
                            }

                            // Update the Members table with the return date
                            string updateMemberQuery = "UPDATE Members SET ReturnDate = @ReturnDate WHERE MemberID = @MemberID";
                            using (SqlCommand updateMemberCmd = new SqlCommand(updateMemberQuery, connection))
                            {
                                updateMemberCmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                                updateMemberCmd.Parameters.AddWithValue("@MemberID", memberID);

                                updateMemberCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Book returned successfully.");
                        }
                        else
                        {
                            MessageBox.Show("The member has not borrowed this book or it has already been returned.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The member has not borrowed this book or it has already been returned.");
                    }
                }
            }
        }

        private void return_book_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
