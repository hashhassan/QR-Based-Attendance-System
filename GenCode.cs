using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_Project
{
    public partial class GenCode : Form
    {
        public GenCode()
        {
            InitializeComponent();
        }

        private void btngenqrcode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbgencodearid.Text))
            {
                MessageBox.Show("Please enter Arid No", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbgencodearid.Focus();
                return;
            }

            String aridregex = @"\d{4}-[Aa][Rr][Ii][Dd]-\d{4}";
            if (!Regex.IsMatch(tbgencodearid.Text, aridregex))
            {
                MessageBox.Show("Please Enter AridNO in this format XXXX-ARID-XXXX", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbgencodearid.Focus();
                return;
            }

            try
            {
                string aridNo = tbgencodearid.Text.Trim();

                bool exists = DatabaseHelper.IsqrDataExists(aridNo);

                if (!exists)
                {
                    MessageBox.Show("Student doesn't exist in system", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbgencodearid.Clear();
                    tbgencodearid.Focus();
                    return;
                }

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(aridNo, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                pictureBox1.Image = qrCodeImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                string folderPath = Path.Combine(Application.StartupPath, "QRCodes");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName = $"QR_{aridNo}.png";
                string filePath = Path.Combine(folderPath, fileName);

                qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                MessageBox.Show($"QR Code generated and saved successfully! File saved at: { filePath}", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenCode_Load(object sender, EventArgs e)
        {

        }
    }
}

