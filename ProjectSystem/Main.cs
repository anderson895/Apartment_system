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
using MySql.Data.MySqlClient;

namespace ProjectSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        // MySQL connection string (adjust with your own database details)
        string connectionString = "Server=localhost;Database=kershey_rental;Uid=root;Pwd=;";


        private void addUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        bool homeExpand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (homeExpand == false) {
               homeContainer.Height += 10;
                if (homeContainer.Height >= 181)
                {
                    HomeTransition.Stop();
                    homeExpand = true;
                }
            }

            else
            {
                homeContainer.Height -= 10;
                if (homeContainer.Height <= 61) {
                    HomeTransition.Stop();
                    homeExpand = false;
                }
            }
        }
        bool dashboardExpand = false;
        private void DashboardTransition_Tick(object sender, EventArgs e)
        {
            if (dashboardExpand == false)
            {
                dashboardContainer.Height += 10;
                if (dashboardContainer.Height >= 181)
                {
                    DashboardTransition.Stop();
                    dashboardExpand = true;
                }
            }

            else
            {
                dashboardContainer.Height -= 10;
                if (dashboardContainer.Height <= 72)
                {
                    DashboardTransition.Stop();
                    dashboardExpand = false;
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void home_Click_1(object sender, EventArgs e)
        {
            HomeTransition.Start();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About uc = new About();
            addUserControl(uc);
        }

        private void contract_Click(object sender, EventArgs e)
        {
            Contract1 uc =new Contract1();  
            addUserControl(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Click_1(object sender, EventArgs e)
        {
            DashboardTransition.Start();
        }

        private void receipt_Click(object sender, EventArgs e)
        {
            ReceiptAndPayment uc =new ReceiptAndPayment();
            addUserControl(uc);
        }

        private void tenants_Click(object sender, EventArgs e)
        {
            Tenants uc =new Tenants();
            addUserControl(uc);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
