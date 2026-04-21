using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace AP_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            tbloginpass.PasswordChar='*';
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            cmboxsubject.SelectedIndex = -1;    
        }

        private void LoadSubjects()
        {
            try
            {
                DataTable dt = DatabaseHelper.GetAllSubjects();
                cmboxsubject.DataSource = dt;
                cmboxsubject.DisplayMember = "subjectname";
                cmboxsubject.ValueMember = "subjectID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (tbloginname.Text == String.Empty) {
                MessageBox.Show("Please enter username", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbloginname.Focus();
                return;
            }
            if (tbloginpass.Text == String.Empty)
            {
                MessageBox.Show("Please enter password", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbloginpass.Focus();
                return;
            }
            if (cmboxsubject.SelectedIndex == -1) { 
                MessageBox.Show("Please select subject", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmboxsubject.Focus();
                return;
            }

            try {
                bool isValid = DatabaseHelper.ValidateLogin(tbloginname.Text, tbloginpass.Text);
                if (isValid)
                {
                    DataRow teacher = DatabaseHelper.GetTeacherDetails(tbloginname.Text, tbloginpass.Text);
                    string teacherID = teacher["teacherID"].ToString();
                    string teacherName = teacher["tname"].ToString();

                    string subjectID = cmboxsubject.SelectedValue.ToString();
                    string subjectName = cmboxsubject.Text;
                    MainForm mainForm = new MainForm(teacherID,teacherName,subjectID,subjectName);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chkboxshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxshowpass.Checked) { 
                tbloginpass.PasswordChar = '\0';
            }
            else
            {
                tbloginpass.PasswordChar = '*';
            }
        }
    }
}
