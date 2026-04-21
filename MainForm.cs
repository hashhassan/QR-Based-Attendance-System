using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_Project
{
    public partial class MainForm : Form
    {
        public string loginteachername;
        public string loginteacherid;
        public string selectedsubject;
        public string selectedsubjectid;
        public MainForm(string loginteacherid, string loginteachername, string selectedsubjectid ,string selectedsubject)
        {
            InitializeComponent();
            this.loginteacherid = loginteacherid;
            this.loginteachername = loginteachername;
            this.selectedsubjectid = selectedsubjectid;
            this.selectedsubject = selectedsubject;
            lbwelcome.Text = "Welcome " + '\n' +loginteachername + "!";
        }

        private void btnmanagestd_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            ManageStd managestdform= new ManageStd();
            managestdform.MdiParent = this;
            managestdform.WindowState = FormWindowState.Maximized;
            managestdform.FormBorderStyle= FormBorderStyle.None;
            managestdform.Dock = DockStyle.Fill;
            managestdform.Show();
        }

        private void btngeneratecode_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            GenCode gencodeform= new GenCode();
            gencodeform.MdiParent = this;
            gencodeform.WindowState = FormWindowState.Maximized;
            gencodeform.FormBorderStyle = FormBorderStyle.None;
            gencodeform.Dock = DockStyle.Fill;
            gencodeform.Show();
        }

        private void btnmarkattendance_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            MarkAtend markatendform= new MarkAtend(loginteacherid,loginteachername,selectedsubjectid, selectedsubject);
            markatendform.MdiParent = this;
            markatendform.WindowState = FormWindowState.Maximized;
            markatendform.FormBorderStyle = FormBorderStyle.None;
            markatendform.Dock = DockStyle.Fill;
            markatendform.Show();
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            AtendReports atendreportsform =new AtendReports(loginteacherid, loginteachername, selectedsubjectid, selectedsubject);
            atendreportsform.MdiParent = this;
            atendreportsform.FormBorderStyle = FormBorderStyle.None;
            atendreportsform.WindowState = FormWindowState.Maximized;
            atendreportsform.Dock = DockStyle.Fill;
            atendreportsform.Show();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnlogout1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                  "Confirm Logout",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
