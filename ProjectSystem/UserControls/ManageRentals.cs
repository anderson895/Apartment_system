using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit; // Ensure you have this for Krypton components
using MySql.Data.MySqlClient;

namespace ProjectSystem.UserControls
{
    public partial class ManageRentals : UserControl
    {
        string connectionString = "Server=localhost;Database=kershey_rental;Uid=root;Pwd=;";

        public ManageRentals()
        {
            InitializeComponent();
        }

        private void ManageRentals_Load(object sender, EventArgs e)
        {
            // Call the method to show existing rental buttons
            ShowExistingRentalButtons();
        }

        private void ShowExistingRentalButtons()
        {
            // Fetch existing tenant codes
            List<string> existingTenantCodes = GetExistingTenantCodes();

            // List of buttons representing tenant codes
            var tenantButtons = new List<KryptonButton> { A11, A12, A13, B11, B12, B13, C11, C12, C13 };

            foreach (var button in tenantButtons)
            {
                // Check if the button's text is in the existing tenant codes
                if (existingTenantCodes.Contains(button.Text))
                {
                    button.Visible = true; // Show button
                    // Alternatively, you can enable the button if it's disabled: button.Enabled = true;
                }
                else
                {
                    button.Visible = false; // Hide button if not in the list
                    // Alternatively, you can disable the button if it's enabled: button.Enabled = false;
                }
            }
        }

        private List<string> GetExistingTenantCodes()
        {
            List<string> tenantCodes = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT t_code FROM tenant";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tenantCodes.Add(reader.GetString(0)); // Assuming t_code is the first column
                }
            }
            return tenantCodes;
        }

        // Event handlers for button clicks
        private void A11_Click(object sender, EventArgs e) { /* Handle click */ }
        private void A12_Click(object sender, EventArgs e) { /* Handle click */ }
        private void A13_Click(object sender, EventArgs e) { /* Handle click */ }
        private void B11_Click(object sender, EventArgs e) { /* Handle click */ }
        private void B12_Click(object sender, EventArgs e) { /* Handle click */ }
        private void B13_Click(object sender, EventArgs e) { /* Handle click */ }
        private void C11_Click(object sender, EventArgs e) { /* Handle click */ }
        private void C12_Click(object sender, EventArgs e) { /* Handle click */ }
        private void C13_Click(object sender, EventArgs e) { /* Handle click */ }
    }
}
