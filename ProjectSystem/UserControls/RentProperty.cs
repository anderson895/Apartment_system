using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectSystem.UserControls
{
    public partial class RentProperty : UserControl
    {
        string connectionString = "Server=localhost;Database=kershey_rental;Uid=root;Pwd=;";

        public RentProperty()
        {
            InitializeComponent();
            HideExistingTenantButtons();
        }

        private void HideExistingTenantButtons()
        {
            // Fetch existing tenant codes
            List<string> existingTenantCodes = GetExistingTenantCodes();

            // List of buttons representing tenant codes
            var tenantButtons = new List<KryptonButton> { A11, A12, A13, B11, B12, B13, C11,C12, C13 };

            foreach (var button in tenantButtons)
            {
                if (existingTenantCodes.Contains(button.Text))
                {
                    button.Visible = false; // Hide button
                    // Alternatively, you can disable the button: button.Enabled = false;
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

        // Event handlers for button clicks...
        private void A11_Click(object sender, EventArgs e) { OpenTenantForm(sender); }
        private void A12_Click(object sender, EventArgs e) { OpenTenantForm(sender); }
        private void A13_Click(object sender, EventArgs e) { OpenTenantForm(sender); }
        private void B11_Click(object sender, EventArgs e) { OpenTenantForm(sender); }
        private void B12_Click(object sender, EventArgs e) { OpenTenantForm(sender); }
        private void B13_Click(object sender, EventArgs e) { OpenTenantForm(sender); }
        private void C11_Click(object sender, EventArgs e) { OpenTenantForm(sender); }
        private void C13_Click(object sender, EventArgs e) { OpenTenantForm(sender); }

        private void OpenTenantForm(object sender)
        {
            KryptonButton t_code = sender as KryptonButton;
            if (t_code != null)
            {
                // Pass the current RentProperty instance to in_tenant_form
                in_tenant_form newForm = new in_tenant_form(t_code.Text, this);
                newForm.Show();
            }
        }

        public void ReloadForm()
        {
            // Refresh the tenant buttons to reflect any changes
            HideExistingTenantButtons(); // Call the method to hide/show buttons based on updated tenant data
        }
    }
}
