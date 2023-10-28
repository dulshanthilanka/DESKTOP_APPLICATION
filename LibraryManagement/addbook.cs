using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagement
{
    public partial class addbook : Form
    {
        public static addbook instance;
        public addbook()
        {
            instance = this;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void name_of_the_bookfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_of_the_book_textfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_of_the_book_textfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_book_save_btn_Click(object sender, EventArgs e)
        {
            // Get the values from the input fields
            string bookName = name_of_the_bookfield.Text;
            string author = author_of_the_book_textfield.Text;
            string isbn = id_of_the_book_textfield.Text; // Assuming ISBN is a string

            // Declare and initialize the variables for PublicationYear and Quantity
            int publicationYear;
            if (int.TryParse(publicationYearTextBox.Text, out publicationYear) == false)
            {
                MessageBox.Show("Publication Year must be a valid integer.");
                return;
            }

            int quantity;
            if (int.TryParse(quantityTextBox.Text, out quantity) == false)
            {
                MessageBox.Show("Quantity must be a valid integer.");
                return;
            }

            // Establish a SQL Server database connection (use your actual connection details)
            string connectionString = "Data Source=THIWANKA;Initial Catalog=library;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                // Create an SQL command to insert the data into the database
                string query = "INSERT INTO Books (Title, Author, ISBN, PublicationYear, Quantity) " +
                               "VALUES (@Title, @Author, @ISBN, @PublicationYear, @Quantity)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Title", bookName);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@PublicationYear", publicationYear);
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Book information saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void add_book_cancel_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
