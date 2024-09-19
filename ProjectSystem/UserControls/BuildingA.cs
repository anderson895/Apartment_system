using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectSystem.UserControls
{
    public partial class BuildingA : UserControl
    {
        private string connectionString = "Server=localhost;Database=kershey_rental;Uid=root;Pwd=;";

        public BuildingA()
        {
            InitializeComponent();
            this.Load += new EventHandler(BuildingA_Load); // Ensure event handler is added
        }

        private void BuildingA_Load(object sender, EventArgs e)
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
                btn_A11.Text,
                btn_A12.Text,
                btn_A13.Text
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
                if (code == btn_A11.Text)
                {
                    exist_A11.BackColor = Color.Green;
                    notexist_A11.BackColor = Color.Transparent; // Reset the not exist panel
                }
                else if (code == btn_A12.Text)
                {
                    exist_A12.BackColor = Color.Green;
                    notexist_A12.BackColor = Color.Transparent; // Reset the not exist panel
                }
                else if (code == btn_A13.Text)
                {
                    exist_A13.BackColor = Color.Green;
                    notexist_A13.BackColor = Color.Transparent; // Reset the not exist panel
                }
            }
            else
            {
                if (code == btn_A11.Text)
                {
                    notexist_A11.BackColor = Color.Red;
                    exist_A11.BackColor = Color.Transparent; // Reset the exist panel
                }
                else if (code == btn_A12.Text)
                {
                    notexist_A12.BackColor = Color.Red;
                    exist_A12.BackColor = Color.Transparent; // Reset the exist panel
                }
                else if (code == btn_A13.Text)
                {
                    notexist_A13.BackColor = Color.Red;
                    exist_A13.BackColor = Color.Transparent; // Reset the exist panel
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
                    view_tenantA newForm = new view_tenantA(tenantCode, this); // Pass the correct tenant code and reference to BuildingA
                    newForm.ShowDialog(); // Show as a dialog to prevent interaction with BuildingA while editing
                }
                else
                {
                    MessageBox.Show($"NOT OCCUPIED"); // Notify the user
                }
            }
        }


        // Ensure event handlers are wired up
        private void btn_A11_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn_A12_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn_A13_Click(object sender, EventArgs e) => btn_Click(sender, e);

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
