using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectSystem.UserControls
{
    public partial class BuildingB : UserControl // Change Form to UserControl
    {
        private string connectionString = "Server=localhost;Database=kershey_rental;Uid=root;Pwd=;";

        public BuildingB()
        {
            InitializeComponent();
            this.Load += new EventHandler(BuildingB_Load); // Change to BuildingB_Load
        }

        private void BuildingB_Load(object sender, EventArgs e)
        {
            // Check and update the status of all tenants when the control loads
            UpdatePanelStatus();
        }

        public void RefreshTenantData()
        {
            // Call to update the tenant status after an update or delete operation
            UpdatePanelStatus();
        }

        private void UpdatePanelStatus()
        {
            // Retrieve the text of each button
            List<string> tenantCodes = new List<string>
            {
                btn_B11.Text,
                btn_B12.Text,
                btn_B13.Text
            };

            // Get existing tenant codes from the database
            List<string> existingTenantCodes = GetExistingTenantCodes();

            // Update panels based on the existence of tenant codes
            foreach (var code in tenantCodes)
            {
                UpdatePanelStatus(code, existingTenantCodes);
            }
        }

        private List<string> GetExistingTenantCodes()
        {
            List<string> tenantCodes = new List<string>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT t_code FROM tenant"; // Fetch all tenant codes
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        tenantCodes.Add(reader.GetString(0)); // Assuming t_code is the first column
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching tenant codes: {ex.Message}"); // Display error message
            }
            return tenantCodes;
        }

        private void UpdatePanelStatus(string code, List<string> existingTenantCodes)
        {
            try
            {
                // Check if the specific tenant code exists
                if (existingTenantCodes.Contains(code))
                {
                    // Set the background color to green if the tenant exists
                    SetPanelColors(code, true);
                }
                else
                {
                    // Set the background color to red if the tenant does not exist
                    SetPanelColors(code, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating panel status: {ex.Message}"); // Display error message
            }
        }

        private void SetPanelColors(string code, bool exists)
        {
            if (exists)
            {
                // Set the background color to green if the tenant exists
                if (code == btn_B11.Text)
                {
                    exist_B11.BackColor = Color.Green; // Ensure you use the correct control names
                    notexist_B11.BackColor = Color.Transparent; // Reset the not exist panel
                }
                else if (code == btn_B12.Text)
                {
                    exist_B12.BackColor = Color.Green;
                    notexist_B12.BackColor = Color.Transparent; // Reset the not exist panel
                }
                else if (code == btn_B13.Text)
                {
                    exist_B13.BackColor = Color.Green;
                    notexist_B13.BackColor = Color.Transparent; // Reset the not exist panel
                }
            }
            else
            {
                // Set the background color to red if the tenant does not exist
                if (code == btn_B11.Text)
                {
                    notexist_B11.BackColor = Color.Red;
                    exist_B11.BackColor = Color.Transparent; // Reset the exist panel
                }
                else if (code == btn_B12.Text)
                {
                    notexist_B12.BackColor = Color.Red;
                    exist_B12.BackColor = Color.Transparent; // Reset the exist panel
                }
                else if (code == btn_B13.Text)
                {
                    notexist_B13.BackColor = Color.Red;
                    exist_B13.BackColor = Color.Transparent; // Reset the exist panel
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // Handle button clicks generically
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string tenantCode = clickedButton.Text; // Use button text for tenant code

                // Check if the tenant exists before attempting to view
                List<string> existingTenantCodes = GetExistingTenantCodes();
                if (existingTenantCodes.Contains(tenantCode))
                {
                    view_tenantB newForm = new view_tenantB(tenantCode, this); // Pass the correct tenant code and reference to BuildingB
                    newForm.ShowDialog(); // Show as a dialog to prevent interaction with BuildingB while editing
                }
                else
                {
                    MessageBox.Show($"NOT OCCUPIED"); // Notify the user
                }
            }
        }

        // Ensure event handlers are wired up
        private void btn_B11_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn_B12_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn_B13_Click(object sender, EventArgs e) => btn_Click(sender, e);
    }
}
