namespace ProjectSystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admin = new System.Windows.Forms.Button();
            this.homeContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.contract = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.Button();
            this.dashboardContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tenants = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.receipt = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.HomeTransition = new System.Windows.Forms.Timer(this.components);
            this.DashboardTransition = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.homeContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.dashboardContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.homeContainer);
            this.flowLayoutPanel1.Controls.Add(this.dashboardContainer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 698);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.admin);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 72);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Image = global::ProjectSystem.Properties.Resources.logo1;
            this.admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin.Location = new System.Drawing.Point(-3, -13);
            this.admin.Name = "admin";
            this.admin.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.admin.Size = new System.Drawing.Size(321, 93);
            this.admin.TabIndex = 1;
            this.admin.Text = "Admin Account";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeContainer
            // 
            this.homeContainer.Controls.Add(this.panel6);
            this.homeContainer.Controls.Add(this.panel7);
            this.homeContainer.Controls.Add(this.panel8);
            this.homeContainer.Location = new System.Drawing.Point(3, 81);
            this.homeContainer.Name = "homeContainer";
            this.homeContainer.Size = new System.Drawing.Size(246, 61);
            this.homeContainer.TabIndex = 3;
            this.homeContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.home);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 61);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Image = global::ProjectSystem.Properties.Resources.home;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(-54, -15);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(75, 0, 30, 0);
            this.home.Size = new System.Drawing.Size(306, 88);
            this.home.TabIndex = 4;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click_1);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.contract);
            this.panel7.Location = new System.Drawing.Point(3, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(277, 47);
            this.panel7.TabIndex = 2;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // contract
            // 
            this.contract.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract.Location = new System.Drawing.Point(-67, -11);
            this.contract.Name = "contract";
            this.contract.Size = new System.Drawing.Size(376, 65);
            this.contract.TabIndex = 4;
            this.contract.Text = "Contract and Agreement";
            this.contract.UseVisualStyleBackColor = true;
            this.contract.Click += new System.EventHandler(this.contract_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.about);
            this.panel8.Location = new System.Drawing.Point(3, 123);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(277, 47);
            this.panel8.TabIndex = 2;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(-78, -8);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(376, 65);
            this.about.TabIndex = 4;
            this.about.Text = "About Apartment";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // dashboardContainer
            // 
            this.dashboardContainer.Controls.Add(this.panel1);
            this.dashboardContainer.Controls.Add(this.panel4);
            this.dashboardContainer.Controls.Add(this.panel5);
            this.dashboardContainer.Controls.Add(this.panel9);
            this.dashboardContainer.Location = new System.Drawing.Point(3, 148);
            this.dashboardContainer.Name = "dashboardContainer";
            this.dashboardContainer.Size = new System.Drawing.Size(246, 61);
            this.dashboardContainer.TabIndex = 3;
            this.dashboardContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 61);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Image = global::ProjectSystem.Properties.Resources.dashboard;
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(-14, -12);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.dashboard.Size = new System.Drawing.Size(302, 88);
            this.dashboard.TabIndex = 5;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tenants);
            this.panel4.Location = new System.Drawing.Point(3, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 47);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // tenants
            // 
            this.tenants.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenants.Location = new System.Drawing.Point(-74, -13);
            this.tenants.Name = "tenants";
            this.tenants.Size = new System.Drawing.Size(376, 78);
            this.tenants.TabIndex = 4;
            this.tenants.Text = "Tenats Unit";
            this.tenants.UseVisualStyleBackColor = true;
            this.tenants.Click += new System.EventHandler(this.tenants_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.receipt);
            this.panel5.Location = new System.Drawing.Point(3, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 47);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // receipt
            // 
            this.receipt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.receipt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt.Location = new System.Drawing.Point(-74, -10);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(376, 65);
            this.receipt.TabIndex = 4;
            this.receipt.Text = "Receipt and Payment";
            this.receipt.UseVisualStyleBackColor = true;
            this.receipt.Click += new System.EventHandler(this.receipt_Click);
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(3, 176);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 100);
            this.panel9.TabIndex = 0;
            // 
            // HomeTransition
            // 
            this.HomeTransition.Interval = 15;
            this.HomeTransition.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DashboardTransition
            // 
            this.DashboardTransition.Interval = 15;
            this.DashboardTransition.Tick += new System.EventHandler(this.DashboardTransition_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(242, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(779, 698);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1020, 698);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.homeContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.dashboardContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.FlowLayoutPanel dashboardContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer HomeTransition;
        private System.Windows.Forms.FlowLayoutPanel homeContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer DashboardTransition;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button contract;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button tenants;
        private System.Windows.Forms.Button receipt;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelContainer;
    }
}