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
            string connectionString = "Data Source=THIWANKA;Initial Catalog=library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                string bookID = return_id_of_the_book_textfield.Text;
                string memberID = return_book_id_of_the_member_textfield.Text;
                DateTime returnDate = DateTime.Parse(return_book_issue_date_textfield.Text); // Assuming date is in a valid format

                connection.Open();

                // Update Books table to increase quantity and set IsAvailable to 1
                string updateBooksQuery = "UPDATE Books SET Quantity = Quantity + 1, IsAvailable = 1 WHERE BookID = @BookID";
                using (SqlCommand command = new SqlCommand(updateBooksQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.ExecuteNonQuery();
                }

                // Update Borrow table to set ReturnDate
                string updateBorrowQuery = "UPDATE Borrow SET ReturnDate = @ReturnDate WHERE BookID = @BookID AND MemberID = @MemberID";
                using (SqlCommand command = new SqlCommand(updateBorrowQuery, connection))
                {
                    command.Parameters.AddWithValue("@ReturnDate", returnDate);
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    command.ExecuteNonQuery();
                }

                // Update Members table to set PreviousBorrow to false
                string updateMembersQuery = "UPDATE Members SET PreviousBorrow = 0 WHERE MemberID = @MemberID";
                using (SqlCommand command = new SqlCommand(updateMembersQuery, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Book return was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void return_book_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
