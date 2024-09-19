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
    public partial class ReceiptAndPayment : UserControl
    {
        public ReceiptAndPayment()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Rental uc = new Rental();
            addUserControl(uc);
        }
    }
}
