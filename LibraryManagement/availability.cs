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
    public partial class availability : Form
    {
        public availability()
        {
            InitializeComponent();
        }

        private void availability_check_btn_Click(object sender, EventArgs e)
        {
            // Connection string to your database
            string connectionString = "Data Source=THIWANKA;Initial Catalog=library;Integrated Security=True";

            // Get the book ID from the text field
            if (int.TryParse(id_of_the_book_textfield.Text, out int bookId))
            {
                // SQL query to check book availability by ID in the dbo.books table
                string query = "SELECT * FROM dbo.books WHERE BookID = @BookID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                // Book is available
                                availability_grid_area.DataSource = dataTable;
                                MessageBox.Show("Book is available.");
                            }
                            else
                            {
                                // Book is not available
                                availability_grid_area.DataSource = null; // Clear the DataGridView
                                MessageBox.Show("Book is not available.");
                                this.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric book ID.");
            }
        }
    }
}
