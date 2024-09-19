using MySql.Data.MySqlClient;
using ProjectSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSystem
{
    public partial class view_tenantB : Form
    {

        private string tenantCode; // Class-level variable to store the tenant code
        private string connectionString = "Server=localhost;Database=kershey_rental;Uid=root;Pwd=;";
        private BuildingB parentForm; // Reference to the parent form

        public view_tenantB(string Tcode, BuildingB parent)
        {
            InitializeComponent();
            tenantCode = Tcode; // Store the tenant code


            label1.Text = Tcode;


            parentForm = parent; // Store the reference to the parent form
            SetInputFieldsReadOnly(true); // Set fields to read-only by default
        }

        private void view_tenant_Load(object sender, EventArgs e)
        {
            LoadTenantData(); // Call the method when the form loads
        }

        private void LoadTenantData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Query to fetch tenant details based on tenant code
                    string query = "SELECT * FROM tenant WHERE t_code = @Tcode";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Tcode", tenantCode);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Read the first record
                        {
                            // Assuming you have these text boxes to display tenant information
                            t_name.Text = reader["t_name"].ToString(); // Make sure t_name is the correct control name
                            t_contact.Text = reader["t_contact"].ToString();
                            t_deposit.Text = reader["t_deposit"].ToString();

                            // Ensure t_date is a DateTimePicker or similar control
                            if (reader["t_date"] != DBNull.Value) // Check for DBNull
                            {
                                t_date.Value = Convert.ToDateTime(reader["t_date"]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tenant not found."); // Notify if tenant is not found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tenant data: {ex.Message}"); // Display error message
            }
        }

        private void SetInputFieldsReadOnly(bool readOnly)
        {
            t_name.ReadOnly = readOnly;
            t_contact.ReadOnly = readOnly;
            t_deposit.ReadOnly = readOnly;
            t_date.Enabled = !readOnly; // Assuming t_date is a DateTimePicker

            // Set the text box background color to gray if read-only
            Color bgColor = readOnly ? Color.LightGray : SystemColors.Window;
            t_name.BackColor = bgColor;
            t_contact.BackColor = bgColor;
            t_deposit.BackColor = bgColor;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SetInputFieldsReadOnly(false); // Enable editing
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            // Update tenant information in the database
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE tenant SET t_name = @Name, t_contact = @Contact, t_deposit = @Deposit, t_date = @Date WHERE t_code = @Tcode";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", t_name.Text);
                    command.Parameters.AddWithValue("@Contact", t_contact.Text);
                    command.Parameters.AddWithValue("@Deposit", t_deposit.Text);
                    command.Parameters.AddWithValue("@Date", t_date.Value);
                    command.Parameters.AddWithValue("@Tcode", tenantCode);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tenant information updated successfully.");
                        parentForm.RefreshTenantData(); // Refresh parent form
                        this.Close(); // Close view_tenant form
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Tenant not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating tenant data: {ex.Message}");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before deleting the tenant record
            var result = MessageBox.Show("Are you sure you want to delete this tenant?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Proceed with deleting tenant record from the database
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM tenant WHERE t_code = @Tcode";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Tcode", tenantCode);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tenant deleted successfully.");
                            parentForm.RefreshTenantData(); // Refresh parent form
                            this.Close(); // Close view_tenant form
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Tenant not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting tenant data: {ex.Message}");
                }
            }
        }
    }
}

