using System;
using System.Windows.Forms;

namespace ProjectSystem.UserControls
{
    public partial class Tenants : UserControl
    {
        public Tenants()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            // Clear any previously loaded user controls
            panelContainer.Controls.Clear();
            // Add the new user control
            panelContainer.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill; // Ensure it fills the container
            userControl.BringToFront(); // Bring the newly added control to the front
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            // Create and display BuildingA user control
            BuildingA buildingAControl = new BuildingA();
            addUserControl(buildingAControl);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            // Create and display BuildingB user control
            BuildingB buildingBControl = new BuildingB();
            addUserControl(buildingBControl);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            // Create and display BuildingC user control
            BuildingC buildingCControl = new BuildingC();
            addUserControl(buildingCControl);
        }
    }
}
