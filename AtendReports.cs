using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AP_Project
{
    public partial class AtendReports : Form
    {
        string loginteachername;
        string loginteacherid;
        string selectedsubject;
        string selectedsubjectid;

        public AtendReports(string loginteacherid, string loginteachername, string selectedsubjectid, string selectedsubject)
        {
            InitializeComponent();
            this.loginteacherid=loginteacherid;
            this.loginteachername=loginteachername;
            this.selectedsubjectid=selectedsubjectid;
            this.selectedsubject=selectedsubject;
        }

        private void AtendReports_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            cmbsubattend.SelectedIndex = -1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadSubjects()
        {
            try
            {
                DataTable dt = DatabaseHelper.GetAllSubjects();
                cmbsubattend.DataSource = dt;
                cmbsubattend.DisplayMember = "subjectname";
                cmbsubattend.ValueMember = "subjectID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnviewatend_Click(object sender, EventArgs e)
        {
            if (tbaridatend.Text == String.Empty) {
                MessageBox.Show("Please enter ARID No", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbaridatend.Focus();
                return;
            }

            if (cmbsubattend.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbsubattend.Focus();
                return;
            }

            String aridregex = @"\d{4}-[Aa][Rr][Ii][Dd]-\d{4}";
            if (!Regex.IsMatch(tbaridatend.Text, aridregex))
            {
                MessageBox.Show("Please Enter AridNO in this format XXXX-ARID-XXXX", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbaridatend.Focus();
                return;
            }

            try
            {
                string aridNo = tbaridatend.Text.Trim();

                bool exists = DatabaseHelper.IsAridNoExists(aridNo);
                if (!exists)
                {
                    MessageBox.Show("Student not found in system!", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbaridatend.Clear();
                    tbaridatend.Focus();
                    return;
                }

                string subjectID = cmbsubattend.SelectedValue.ToString();

                DataTable dt = DatabaseHelper.GetStudentAttendanceBySubject(aridNo, subjectID);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No attendance records found for this student in selected subject",
                        "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                    return;
                }
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngenreport_Click(object sender, EventArgs e)
        {
            if (tbaridatend.Text == String.Empty)
            {
                MessageBox.Show("Please enter ARID No", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbaridatend.Focus();
                return;
            }

            try
            {
                string aridNo = tbaridatend.Text.Trim();

                bool exists = DatabaseHelper.IsAridNoExists(aridNo);
                if (!exists)
                {
                    MessageBox.Show("Student not found in system!", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbaridatend.Clear();
                    tbaridatend.Focus();
                    return;
                }

                DataTable dt = DatabaseHelper.GetOverallAttendanceReport(aridNo);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No attendance records found for this student",
                        "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView2.DataSource = null;
                    return;
                }

                dataGridView2.DataSource = dt;

                MessageBox.Show($"Overall report generated successfully for {aridNo}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
