using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AP_Project
{
    public partial class ManageStd : Form
    {
        public ManageStd()
        {
            InitializeComponent();
        }

        private void btnaddstd_Click(object sender, EventArgs e)
        {
            if (tbstdname.Text == String.Empty) {
                MessageBox.Show("Please enter username", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbstdname.Focus();
                return;
            }

            if (tbstdaridno.Text == String.Empty) { 
                MessageBox.Show("Please enter ARID No", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbstdaridno.Focus();
                return;
            }
            String nameregex = @"[A-Z][a-z]{2,29}\s[A-Z][a-z]{2,29}";
            if (!Regex.IsMatch(tbstdname.Text, nameregex))
            {
                MessageBox.Show("Please Enter Name in correct Format", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbstdname.Focus();
                return; ;
            }
            String aridregex = @"\d{4}-[Aa][Rr][Ii][Dd]-\d{4}";
            if (!Regex.IsMatch(tbstdaridno.Text, aridregex))
            {
                MessageBox.Show("Please Enter AridNO in this format XXXX-ARID-XXXX", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbstdname.Focus();
                return;
            }

            bool exits = DatabaseHelper.IsAridNoExists(tbfilteraridno.Text);
            if (exits)
            {
                MessageBox.Show("Student already exists in System. Add another!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbfilteraridno.Focus();
                return;
            }

            try {
                bool isAdded = DatabaseHelper.AddStudent(tbstdname.Text, tbstdaridno.Text);
                if (isAdded)
                {
                    MessageBox.Show("Student added successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbstdname.Clear();
                    tbstdaridno.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add student", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdatestd_Click(object sender, EventArgs e)
        {
            if (tbstdaridno.Text == String.Empty)
            {
                MessageBox.Show("Please enter ARID No to Update", "Insertion Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbstdaridno.Focus();
                return;
            }

            if (tbstdname.Text == String.Empty)
            {
                MessageBox.Show("Please enter Name to Update", "Insertion Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbstdaridno.Focus();
                return;
            }

            try
            {
                bool isUpdated = DatabaseHelper.UpdateStudent(tbstdname.Text, tbstdaridno.Text);
                if (isUpdated)
                {
                    MessageBox.Show("Student Updated successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbstdname.Clear();
                    tbstdaridno.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Update student", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btndeletestd_Click(object sender, EventArgs e)
        {
            if (tbstdaridno.Text == String.Empty) { 
                MessageBox.Show("Please enter ARID No to Delete", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbstdaridno.Focus();
                return;
            }

            String aridregex = @"\d{4}-[Aa][Rr][Ii][Dd]-\d{4}";
            if (!Regex.IsMatch(tbstdaridno.Text, aridregex))
            {
                MessageBox.Show("Please Enter ArinNO in this format XXXX-ARID-XXXX", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbstdname.Focus();
                return;
            }
            try
            {
                bool isDeleted = DatabaseHelper.DeleteStudent(tbstdaridno.Text);
                if (isDeleted)
                {
                    MessageBox.Show("Student Deleted successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbstdname.Clear();
                    tbstdaridno.Clear();
                }
                else { 
                    MessageBox.Show("Failed to Delete student", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageStd_Load(object sender, EventArgs e)
        {
            loadStudents();

        }

        private void loadStudents()
        {
            try
            {
                DataTable dataTable = DatabaseHelper.GetAllStudents();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["qrdata"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnfilterstd_Click(object sender, EventArgs e)
        {
            if (tbfilteraridno.Text == String.Empty) { 
                MessageBox.Show("Please enter ARID No to Filter", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbfilteraridno.Focus();
                return;
            }

            String aridregex = @"\d{4}-[Aa][Rr][Ii][Dd]-\d{4}";
            if (!Regex.IsMatch(tbfilteraridno.Text, aridregex))
            {
                MessageBox.Show("Please Enter ArinNO in this format XXXX-ARID-XXXX", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbstdname.Focus();
                return;
            }

            try
            {
                DataRow datarow = DatabaseHelper.filterStudents(tbfilteraridno.Text);
                if (datarow == null) 
                {
                    MessageBox.Show("No student found with the given ARID No", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable dataTable = datarow.Table.Clone();
                dataTable.ImportRow(datarow);

                dataGridView1.DataSource = dataTable;   
                dataGridView1.Columns["qrdata"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
