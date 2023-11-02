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
    public partial class borrowbook : Form
    {
        public borrowbook()
        {
            InitializeComponent();
        }

        private void borrow_book_borrow_btn_Click(object sender, EventArgs e)
        {
            // Get input values from the text fields
            string bookISBN = borrow_id_of_the_book_textfield.Text;
            int memberID;
            DateTime issueDate;

            if (!int.TryParse(borrow_book_id_of_the_member_textfield.Text, out memberID))
            {
                MessageBox.Show("Invalid Member ID. Please enter a valid integer.");
                return;
            }

            if (!DateTime.TryParse(borrow_book_issue_date_textfield.Text, out issueDate))
            {
                MessageBox.Show("Invalid Date. Please enter a valid date in the correct format.");
                return;
            }

            // Replace "Your_Connection_String_Here" with your actual connection string
            string connectionString = "Data Source=THIWANKA;Initial Catalog=library;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check availability
                string checkAvailabilityQuery = "SELECT Quantity, IsAvailable FROM Books WHERE ISBN = @ISBN";
                using (SqlCommand checkAvailabilityCmd = new SqlCommand(checkAvailabilityQuery, connection))
                {
                    checkAvailabilityCmd.Parameters.AddWithValue("@ISBN", bookISBN);

                    using (SqlDataReader availabilityReader = checkAvailabilityCmd.ExecuteReader())
                    {
                        if (availabilityReader.Read())
                        {
                            int quantity = availabilityReader.GetInt32(0);
                            bool isAvailable = availabilityReader.GetBoolean(1);

                            if (quantity > 0 && isAvailable)
                            {
                                availabilityReader.Close(); // Close the availabilityReader

                                // Check if the member has returned previous books using a separate connection
                                using (SqlConnection innerConnection = new SqlConnection(connectionString))
                                {
                                    innerConnection.Open();
                                    string checkMemberQuery = "SELECT COUNT(*) FROM Borrow WHERE MemberID = @MemberID AND ReturnDate IS NULL";
                                    using (SqlCommand checkMemberCmd = new SqlCommand(checkMemberQuery, innerConnection))
                                    {
                                        checkMemberCmd.Parameters.AddWithValue("@MemberID", memberID);

                                        int activeBorrowCount = (int)checkMemberCmd.ExecuteScalar();

                                        if (activeBorrowCount == 0)
                                        {
                                            // Borrow the book
                                            string borrowBookQuery = "INSERT INTO Borrow (MemberID, BookID, IssueDate) VALUES (@MemberID, @BookID, @IssueDate)";
                                            using (SqlCommand borrowBookCmd = new SqlCommand(borrowBookQuery, connection))
                                            {
                                                borrowBookCmd.Parameters.AddWithValue("@MemberID", memberID);
                                                borrowBookCmd.Parameters.AddWithValue("@BookID", bookISBN); // Assuming bookISBN corresponds to BookID
                                                borrowBookCmd.Parameters.AddWithValue("@IssueDate", issueDate);

                                                borrowBookCmd.ExecuteNonQuery();

                                                // Update the Books table to decrease quantity and mark as unavailable
                                                string updateBookQuery = "UPDATE Books SET Quantity = Quantity - 1, IsAvailable = 0 WHERE ISBN = @ISBN";
                                                using (SqlCommand updateBookCmd = new SqlCommand(updateBookQuery, connection))
                                                {
                                                    updateBookCmd.Parameters.AddWithValue("@ISBN", bookISBN);

                                                    updateBookCmd.ExecuteNonQuery();
                                                }

                                                MessageBox.Show("Borrow successful.");
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("The member has not returned a previous book.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("The book is not available.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Book with ISBN not found.");
                        }
                    }
                }
            }
        }

        private void borrow_book_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrow_book_id_of_the_member_textfield_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
