using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjectSystem.UserControls;

namespace ProjectSystem
{
    public partial class in_tenant_form : Form
    {
        private string Tcode;
        private RentProperty rentPropertyForm; // Reference to the RentProperty form

        string connectionString = "Server=localhost;Database=kershey_rental;Uid=root;Pwd=;";

        // Constructor that accepts RentProperty instance
        public in_tenant_form(string Tcode, RentProperty rentProperty)
        {
            InitializeComponent();
            this.Tcode = Tcode;
            this.rentPropertyForm = rentProperty; // Initialize the reference

            if (t_code != null)
            {
                t_code.Text = Tcode;
            }
            else
            {
                MessageBox.Show("t_code control is not initialized.");
            }
        }

        private void btn_save_tenant_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(t_name.Text) ||
                string.IsNullOrWhiteSpace(t_contact.Text) ||
                string.IsNullOrWhiteSpace(t_deposit.Text) ||
                t_date.Value == null)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Prepare the connection and SQL command
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO `tenant` (`t_code`, `t_name`, `t_contact`, `t_date`, `t_deposit`) " +
                                   "VALUES (@Tcode, @Name, @Contact, @Date, @Deposit)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Set parameters
                        cmd.Parameters.AddWithValue("@Tcode", t_code.Text);
                        cmd.Parameters.AddWithValue("@Name", t_name.Text);
                        cmd.Parameters.AddWithValue("@Contact", t_contact.Text);
                        cmd.Parameters.AddWithValue("@Date", t_date.Value);
                        cmd.Parameters.AddWithValue("@Deposit", decimal.Parse(t_deposit.Text));

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tenant information saved successfully.");

                    // Reload the RentProperty form
                    rentPropertyForm.ReloadForm(); // Call the reload method

                    // Close the in_tenant_form
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
