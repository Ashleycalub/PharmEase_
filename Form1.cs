using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmEase_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            LogInPanel.Visible = false;
            AdminPanel.Visible = true;
            ButtonsPanel.Visible = true;
            DashboardPanel.Visible = true;
            AddUserPanel.Visible = false;
            ViewUserPanel.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LogInPanel.Visible = false;
            AdminPanel.Visible = true;
            ButtonsPanel.Visible = true;
            DashboardPanel.Visible = true;
            AddUserPanel.Visible = false;
            ViewUserPanel.Visible = false;
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            LogInPanel.Visible = false;
            AdminPanel.Visible = true;
            ButtonsPanel.Visible = true;
            DashboardPanel.Visible = false;
            AddUserPanel.Visible = true;
            ViewUserPanel.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogInPanel.Visible = true;
            AdminPanel.Visible = true;
            ButtonsPanel.Visible = true;
            DashboardPanel.Visible = false;
            AddUserPanel.Visible = false;
            ViewUserPanel.Visible = false;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {

        }


        private void btnViewUser_Click(object sender, EventArgs e)
        {
            LogInPanel.Visible = false;
            AdminPanel.Visible = true;
            ButtonsPanel.Visible = true;
            DashboardPanel.Visible = false;
            AddUserPanel.Visible = false;
            ViewUserPanel.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LogInPanel.Visible = false;
            AdminPanel.Visible = true;
            ButtonsPanel.Visible = true;
            DashboardPanel.Visible = false;
            AddUserPanel.Visible = false;
            ViewUserPanel.Visible = false;
            ProfilePanel.Visible = true;
        }
    }
}
