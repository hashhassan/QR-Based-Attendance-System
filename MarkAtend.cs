using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ZXing;
using System.Media;

namespace AP_Project
{
    public partial class MarkAtend : Form
    {
        private FilterInfoCollection videoDevices;  
        private VideoCaptureDevice videoSource;
        string loginteachername;
        string loginteacherid;
        string selectedsubject;
        string selectedsubjectid;
        private int frameCount = 0;
        private string lastScannedCode = "";
        private DateTime lastScanTime = DateTime.MinValue;


        public MarkAtend(string loginteacherid, string loginteachername, string selectedsubjectid, string selectedsubject)
        {
            InitializeComponent();
            this.loginteacherid = loginteacherid;
            this.loginteachername = loginteachername;
            this.selectedsubjectid = selectedsubjectid;
            this.selectedsubject = selectedsubject;

        }

        private void MarkAtend_Load(object sender, EventArgs e)
        {
            lbteacher.Text= $"Teacher: {loginteachername}";
            lbsubject.Text= $"Subject: {selectedsubject}";
            lbdate.Text= $"Date: {DateTime.Now.ToShortDateString()}";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            LoadCameras();
        }

        private void LoadCameras()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No camera found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

                // Set highest resolution
                if (videoSource.VideoCapabilities.Length > 0)
                {
                    videoSource.VideoResolution = videoSource.VideoCapabilities[videoSource.VideoCapabilities.Length - 1];
                }

                videoSource.NewFrame += VideoSource_NewFrame;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Camera error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btstartcamera_Click(object sender, EventArgs e)
        {
            if (videoSource != null && !videoSource.IsRunning)
            {
                videoSource.Start();
                btstartcamera.Enabled = false;
                btnstopcamera.Enabled = true;
            }
        }

        private void btnstopcamera_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                btstartcamera.Enabled = true;
                btnstopcamera.Enabled = false;
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

                // Display in PictureBox
                if (pictureBox1.InvokeRequired)
                {
                    pictureBox1.Invoke(new Action(() =>
                    {
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                        }

                        pictureBox1.Image = bitmap;
                    }));
                }

                // Scan every 3rd frame only
                frameCount++;
                if (frameCount % 3 == 0)
                {
                    ScanQRCode((Bitmap)bitmap.Clone());
                }
            }
            catch (Exception)
            {
                // Ignore
            }
        }

        private void ScanQRCode(Bitmap bitmap)
        {
            try
            {
                BarcodeReader reader = new BarcodeReader
                {
                    AutoRotate = false,
                    Options = new ZXing.Common.DecodingOptions
                    {
                        TryHarder = false,
                        PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE }
                    }
                };

                var result = reader.Decode(bitmap);

                if (result != null)
                {
                    string scannedAridNo = result.Text;

                    // Prevent duplicate scans
                    if (scannedAridNo == lastScannedCode &&
                        (DateTime.Now - lastScanTime).TotalSeconds < 5)
                    {
                        return;
                    }

                    lastScannedCode = scannedAridNo;
                    lastScanTime = DateTime.Now;

                    this.Invoke(new Action(() =>
                    {
                        ProcessAttendance(scannedAridNo);
                    }));
                }
            }
            catch (Exception)
            {
                // Ignore
            }
            finally
            {
                bitmap.Dispose();
            }
        }

        private void ProcessAttendance(string aridNo)
        {
            try
            {
                DataRow student = DatabaseHelper.GetStudentByAridNo(aridNo);

                if (student == null)
                {
                    MessageBox.Show("Student not found in system!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool alreadyMarked = DatabaseHelper.IsAttendanceMarkedToday(
                    aridNo, selectedsubjectid, loginteacherid);

                if (alreadyMarked)
                {
                    MessageBox.Show($"Attendance already marked today for:{ student["stdname"]} ({ aridNo})",
                        "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool success = DatabaseHelper.MarkAttendance(aridNo, selectedsubjectid, loginteacherid);

                if (success)
                {
                    MessageBox.Show($"Attendance Marked Successfully! '\n' Student: { student["stdname"]} '\n' Arid No: { aridNo} '\n' Subject: { selectedsubject}Date: { DateTime.Now.ToString("dd-MMM-yyyy")}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SystemSounds.Beep.Play();

                    listBox1.Items.Add($"{student["stdname"]} - {aridNo} - {DateTime.Now.ToString("hh:mm tt")}");
                }
                else
                {
                    MessageBox.Show("Failed to mark attendance!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmarkremainingabsent_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable allStudents = DatabaseHelper.GetAllStudents();

                if (allStudents.Rows.Count == 0)
                {
                    MessageBox.Show("No students found in system", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"This will mark all students who haven't scanned as ABSENT for {selectedsubject}.\n\nAre you sure?",
                    "Confirm Mark Absent",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }

                int absentCount = 0;

                foreach (DataRow student in allStudents.Rows)
                {
                    string aridNo = student["aridno"].ToString();

                    bool alreadyMarked = DatabaseHelper.IsAttendanceMarkedToday(
                        aridNo, selectedsubjectid, loginteacherid);

                    if (!alreadyMarked)
                    {
                        bool marked = DatabaseHelper.MarkAbsent(aridNo, selectedsubjectid, loginteacherid);

                        if (marked)
                        {
                            absentCount++;
                        }
                    }
                }

                MessageBox.Show($"{absentCount} students marked as ABSENT",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MarkAtend_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource = null;
                }

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
