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
    public partial class register_member : Form
    {
        public register_member()
        {
            InitializeComponent();
        }

        private void register_member_save_btn_Click(object sender, EventArgs e)
        {
            // Get input values from text fields
            if (int.TryParse(member_id_textfield.Text, out int memberID) &&
                !string.IsNullOrEmpty(name_of_the_member_textfield.Text) &&
                !string.IsNullOrEmpty(phone_number_field.Text) &&
                DateTime.TryParse(register_date_of_the_member_textfield.Text, out DateTime registrationDate))
            {
                // Connection string to your database
                string connectionString = "Data Source=THIWANKA;Initial Catalog=library;Integrated Security=True";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // SQL command to insert a new member into the "Members" table
                        string insertQuery = @"
                    INSERT INTO Members (MemberID, Name, PhoneNumber, RegistrationDate)
                    VALUES (@MemberID, @Name, @PhoneNumber, @RegistrationDate);";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MemberID", memberID);
                            command.Parameters.AddWithValue("@Name", name_of_the_member_textfield.Text);
                            command.Parameters.AddWithValue("@PhoneNumber", phone_number_field.Text);
                            command.Parameters.AddWithValue("@RegistrationDate", registrationDate);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Member added successfully.");
                                this.Close(); // Close the form
                            }
                            else
                            {
                                MessageBox.Show("Error adding member.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid member information.");
            }
        }

        private void register_member_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
