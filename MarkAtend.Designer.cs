namespace AP_Project
{
    partial class MarkAtend
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbteacher = new System.Windows.Forms.Label();
            this.lbsubject = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btstartcamera = new System.Windows.Forms.Button();
            this.btnstopcamera = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmarkremainingabsent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mark Attendance Form";
            // 
            // lbteacher
            // 
            this.lbteacher.AutoSize = true;
            this.lbteacher.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbteacher.Location = new System.Drawing.Point(7, 32);
            this.lbteacher.Name = "lbteacher";
            this.lbteacher.Size = new System.Drawing.Size(74, 21);
            this.lbteacher.TabIndex = 2;
            this.lbteacher.Text = "Teacher: ";
            // 
            // lbsubject
            // 
            this.lbsubject.AutoSize = true;
            this.lbsubject.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsubject.Location = new System.Drawing.Point(7, 7);
            this.lbsubject.Name = "lbsubject";
            this.lbsubject.Size = new System.Drawing.Size(73, 21);
            this.lbsubject.TabIndex = 3;
            this.lbsubject.Text = "Subject: ";
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(7, 56);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(48, 21);
            this.lbdate.TabIndex = 4;
            this.lbdate.Text = "Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(247, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btstartcamera
            // 
            this.btstartcamera.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstartcamera.Location = new System.Drawing.Point(10, 81);
            this.btstartcamera.Name = "btstartcamera";
            this.btstartcamera.Size = new System.Drawing.Size(205, 41);
            this.btstartcamera.TabIndex = 7;
            this.btstartcamera.Text = "Start Camera To Scan";
            this.btstartcamera.UseVisualStyleBackColor = true;
            this.btstartcamera.Click += new System.EventHandler(this.btstartcamera_Click);
            // 
            // btnstopcamera
            // 
            this.btnstopcamera.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstopcamera.Location = new System.Drawing.Point(10, 128);
            this.btnstopcamera.Name = "btnstopcamera";
            this.btnstopcamera.Size = new System.Drawing.Size(205, 41);
            this.btnstopcamera.TabIndex = 8;
            this.btnstopcamera.Text = "Stop Camera";
            this.btnstopcamera.UseVisualStyleBackColor = true;
            this.btnstopcamera.Click += new System.EventHandler(this.btnstopcamera_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(11, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 312);
            this.listBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = " Students who have \r\nbeen marked present:\r\n";
            // 
            // btnmarkremainingabsent
            // 
            this.btnmarkremainingabsent.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarkremainingabsent.Location = new System.Drawing.Point(11, 519);
            this.btnmarkremainingabsent.Name = "btnmarkremainingabsent";
            this.btnmarkremainingabsent.Size = new System.Drawing.Size(205, 55);
            this.btnmarkremainingabsent.TabIndex = 11;
            this.btnmarkremainingabsent.Text = "Mark Remaining Absent";
            this.btnmarkremainingabsent.UseVisualStyleBackColor = true;
            this.btnmarkremainingabsent.Click += new System.EventHandler(this.btnmarkremainingabsent_Click);
            // 
            // MarkAtend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 586);
            this.ControlBox = false;
            this.Controls.Add(this.btnmarkremainingabsent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnstopcamera);
            this.Controls.Add(this.btstartcamera);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbsubject);
            this.Controls.Add(this.lbteacher);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarkAtend";
            this.Text = "MarkAtend";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MarkAtend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbteacher;
        private System.Windows.Forms.Label lbsubject;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btstartcamera;
        private System.Windows.Forms.Button btnstopcamera;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmarkremainingabsent;
    }
}