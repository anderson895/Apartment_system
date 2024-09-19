using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSystem.UserControls
{
    public partial class Rental : UserControl
    {
        public Rental()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void ManageRentals_Click(object sender, EventArgs e)
        {
            ManageRentals uc = new ManageRentals();
            addUserControl(uc);
        }

        private void RentProperty_Click(object sender, EventArgs e)
        {
            RentProperty uc = new RentProperty();   
            addUserControl(uc);
        }
    }
}
