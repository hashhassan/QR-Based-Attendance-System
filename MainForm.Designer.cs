namespace AP_Project
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout1 = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbwelcome = new System.Windows.Forms.Label();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnmarkattendance = new System.Windows.Forms.Button();
            this.btngeneratecode = new System.Windows.Forms.Button();
            this.btnmanagestd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnlogout1);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.lbwelcome);
            this.panel1.Controls.Add(this.btnreports);
            this.panel1.Controls.Add(this.btnmarkattendance);
            this.panel1.Controls.Add(this.btngeneratecode);
            this.panel1.Controls.Add(this.btnmanagestd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 605);
            this.panel1.TabIndex = 1;
            // 
            // btnlogout1
            // 
            this.btnlogout1.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout1.Location = new System.Drawing.Point(-2, 232);
            this.btnlogout1.Name = "btnlogout1";
            this.btnlogout1.Size = new System.Drawing.Size(198, 52);
            this.btnlogout1.TabIndex = 8;
            this.btnlogout1.Text = "Logout";
            this.btnlogout1.UseVisualStyleBackColor = true;
            this.btnlogout1.Click += new System.EventHandler(this.btnlogout1_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(-1, 185);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(198, 52);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit Application";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbwelcome
            // 
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwelcome.Location = new System.Drawing.Point(33, 324);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(119, 31);
            this.lbwelcome.TabIndex = 3;
            this.lbwelcome.Text = "Welcome";
            // 
            // btnreports
            // 
            this.btnreports.Font = new System.Drawing.Font("Simplified Arabic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreports.Location = new System.Drawing.Point(-1, 139);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(198, 52);
            this.btnreports.TabIndex = 5;
            this.btnreports.Text = "Attendance Reports";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnmarkattendance
            // 
            this.btnmarkattendance.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarkattendance.Location = new System.Drawing.Point(-1, 94);
            this.btnmarkattendance.Name = "btnmarkattendance";
            this.btnmarkattendance.Size = new System.Drawing.Size(198, 52);
            this.btnmarkattendance.TabIndex = 4;
            this.btnmarkattendance.Text = "Mark Attendance";
            this.btnmarkattendance.UseVisualStyleBackColor = true;
            this.btnmarkattendance.Click += new System.EventHandler(this.btnmarkattendance_Click);
            // 
            // btngeneratecode
            // 
            this.btngeneratecode.Font = new System.Drawing.Font("Simplified Arabic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneratecode.Location = new System.Drawing.Point(-1, 46);
            this.btngeneratecode.Name = "btngeneratecode";
            this.btngeneratecode.Size = new System.Drawing.Size(198, 52);
            this.btngeneratecode.TabIndex = 3;
            this.btngeneratecode.Text = "Generate QR Code";
            this.btngeneratecode.UseVisualStyleBackColor = true;
            this.btngeneratecode.Click += new System.EventHandler(this.btngeneratecode_Click);
            // 
            // btnmanagestd
            // 
            this.btnmanagestd.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagestd.Location = new System.Drawing.Point(-1, -2);
            this.btnmanagestd.Name = "btnmanagestd";
            this.btnmanagestd.Size = new System.Drawing.Size(198, 52);
            this.btnmanagestd.TabIndex = 2;
            this.btnmanagestd.Text = "Manage Students";
            this.btnmanagestd.UseVisualStyleBackColor = true;
            this.btnmanagestd.Click += new System.EventHandler(this.btnmanagestd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 605);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnmarkattendance;
        private System.Windows.Forms.Button btngeneratecode;
        private System.Windows.Forms.Button btnmanagestd;
        private System.Windows.Forms.Label lbwelcome;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogout1;
    }
}

