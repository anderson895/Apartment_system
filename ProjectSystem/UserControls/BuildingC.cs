using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectSystem.UserControls
{
    public partial class BuildingC : UserControl
    {
        private string connectionString = "Server=localhost;Database=kershey_rental;Uid=root;Pwd=;";

        public BuildingC()
        {
            InitializeComponent();
            this.Load += new EventHandler(BuildingC_Load); // Correct event handler method name
        }

        private void BuildingC_Load(object sender, EventArgs e)
        {
            // Check and update the status of all tenants when the form loads
            UpdatePanelStatus();
        }

        public void RefreshTenantData()
        {
            // Refresh tenant data after an update or delete operation
            UpdatePanelStatus();
        }

        private void UpdatePanelStatus()
        {
            // Retrieve the text (codes) of each button
            List<string> tenantCodes = new List<string>
            {
                btn_C11.Text,
                btn_C12.Text,
                btn_C13.Text
            };

            // Get existing tenant codes from the database
            List<string> existingTenantCodes = GetExistingTenantCodes();

            // Update panel status for each tenant code
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
                MessageBox.Show($"Error fetching tenant codes: {ex.Message}");
            }
            return tenantCodes;
        }

        private void UpdatePanelStatus(string code, List<string> existingTenantCodes)
        {
            try
            {
                // Check if the specific tenant code exists
                bool tenantExists = existingTenantCodes.Contains(code);
                SetPanelColors(code, tenantExists);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating panel status: {ex.Message}");
            }
        }

        private void SetPanelColors(string code, bool exists)
        {
            // Dictionary to map tenant codes to controls
            var panelMappings = new Dictionary<string, (Panel existPanel, Panel notExistPanel)>
            {
                { btn_C11.Text, (exist_C11, notexist_C11) },
                { btn_C12.Text, (exist_C12, notexist_C12) },
                { btn_C13.Text, (exist_C13, notexist_C13) }
            };

            // Check if the code exists in the panel mappings and update colors
            if (panelMappings.TryGetValue(code, out var panels))
            {
                if (exists)
                {
                    panels.existPanel.BackColor = Color.Green;
                    panels.notExistPanel.BackColor = Color.Transparent;
                }
                else
                {
                    panels.notExistPanel.BackColor = Color.Red;
                    panels.existPanel.BackColor = Color.Transparent;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string tenantCode = clickedButton.Text; // Use button text as tenant code

                // Check if the tenant exists before attempting to view
                List<string> existingTenantCodes = GetExistingTenantCodes();
                if (existingTenantCodes.Contains(tenantCode))
                {
                    view_tenantC newForm = new view_tenantC(tenantCode, this); // Pass tenant code and form reference
                    newForm.ShowDialog(); // Show as dialog to prevent interaction with BuildingC while editing
                }
                else
                {
                    MessageBox.Show($"NOT OCCUPIED"); // Notify the user if not occupied
                }
            }
        }

        // Wire up button click events
        private void btn_C11_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn_C12_Click(object sender, EventArgs e) => btn_Click(sender, e);
        private void btn_C13_Click(object sender, EventArgs e) => btn_Click(sender, e);
    }
}
