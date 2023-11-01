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
            string bookISBN = borrrow_id_of_the_book_textfield.Text; // Get the ISBN from the input field
            int memberId;
            DateTime issueDate;

            if (int.TryParse(borrow_book_id_of_the_member_textfield.Text, out memberId) &&
                DateTime.TryParse(borrow_book_issue_date_textfield.Text, out issueDate))
            {
                BorrowBook(bookISBN, memberId, issueDate);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid values.");
            }
        }

        private void BorrowBook(string bookISBN, int memberId, DateTime issueDate)
        {
            string connectionString = "Data Source=THIWANKA;Initial Catalog=library;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the book is available using ISBN
                    string bookAvailabilityQuery = "SELECT * FROM Books WHERE ISBN = @bookISBN";
                    using (SqlCommand bookAvailabilityCommand = new SqlCommand(bookAvailabilityQuery, connection))
                    {
                        bookAvailabilityCommand.Parameters.AddWithValue("@bookISBN", bookISBN);

                        using (SqlDataReader bookAvailabilityReader = bookAvailabilityCommand.ExecuteReader())
                        {
                            if (bookAvailabilityReader.Read())
                            {
                                int bookQuantity = bookAvailabilityReader.GetInt32(bookAvailabilityReader.GetOrdinal("Quantity"));

                                if (bookQuantity > 0)
                                {
                                    // Book is available, decrement the quantity and update "IsAvailable"
                                    string updateBookQuery = "UPDATE Books SET Quantity = @newQuantity, IsAvailable = @isAvailable WHERE ISBN = @bookISBN";
                                    using (SqlCommand updateBookCommand = new SqlCommand(updateBookQuery, connection))
                                    {
                                        updateBookCommand.Parameters.AddWithValue("@bookISBN", bookISBN);
                                        updateBookCommand.Parameters.AddWithValue("@newQuantity", bookQuantity - 1);
                                        updateBookCommand.Parameters.AddWithValue("@isAvailable", bookQuantity - 1 > 0 ? 1 : 0); // Set IsAvailable based on quantity

                                        updateBookCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("The selected book is not available for borrowing. Out of stock.");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("The selected book was not found.");
                                return;
                            }
                        }
                    }

                    // Check if the member has returned previous books
                    string memberReturnQuery = "SELECT COUNT(*) FROM Borrow WHERE MemberID = @memberId AND ReturnDate IS NULL";
                    using (SqlCommand memberReturnCommand = new SqlCommand(memberReturnQuery, connection))
                    {
                        memberReturnCommand.Parameters.AddWithValue("@memberId", memberId);

                        int activeBorrowedBooks = (int)memberReturnCommand.ExecuteScalar();

                        if (activeBorrowedBooks > 0)
                        {
                            MessageBox.Show("The member has not returned previous books.");
                            return;
                        }
                    }

                    // If all checks pass, you can add the borrowing record to the database
                    string borrowBookQuery = "INSERT INTO Borrow (MemberID, BookID, IssueDate) VALUES (@memberId, (SELECT BookID FROM Books WHERE ISBN = @bookISBN), @issueDate)";
                    using (SqlCommand borrowBookCommand = new SqlCommand(borrowBookQuery, connection))
                    {
                        borrowBookCommand.Parameters.AddWithValue("@memberId", memberId);
                        borrowBookCommand.Parameters.AddWithValue("@bookISBN", bookISBN);
                        borrowBookCommand.Parameters.AddWithValue("@issueDate", issueDate);

                        borrowBookCommand.ExecuteNonQuery();

                        MessageBox.Show("Borrowed successfully!");
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                // Optionally, you can log the error or perform further error handling.
            }
        }

        private void borrow_book_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
