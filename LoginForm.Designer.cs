namespace AP_Project
{
    partial class LoginForm
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
            this.cmboxsubject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkboxshowpass = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.tbloginpass = new System.Windows.Forms.TextBox();
            this.tbloginname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmboxsubject);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkboxshowpass);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.tbloginpass);
            this.panel1.Controls.Add(this.tbloginname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(230, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 447);
            this.panel1.TabIndex = 1;
            // 
            // cmboxsubject
            // 
            this.cmboxsubject.FormattingEnabled = true;
            this.cmboxsubject.Location = new System.Drawing.Point(42, 305);
            this.cmboxsubject.Name = "cmboxsubject";
            this.cmboxsubject.Size = new System.Drawing.Size(209, 21);
            this.cmboxsubject.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Subject";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkboxshowpass
            // 
            this.chkboxshowpass.AutoSize = true;
            this.chkboxshowpass.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxshowpass.Location = new System.Drawing.Point(42, 234);
            this.chkboxshowpass.Name = "chkboxshowpass";
            this.chkboxshowpass.Size = new System.Drawing.Size(130, 20);
            this.chkboxshowpass.TabIndex = 5;
            this.chkboxshowpass.Text = "Show Passowrd";
            this.chkboxshowpass.UseVisualStyleBackColor = true;
            this.chkboxshowpass.CheckedChanged += new System.EventHandler(this.chkboxshowpass_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Nirmala Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(42, 345);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(209, 43);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // tbloginpass
            // 
            this.tbloginpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbloginpass.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbloginpass.Location = new System.Drawing.Point(38, 193);
            this.tbloginpass.Multiline = true;
            this.tbloginpass.Name = "tbloginpass";
            this.tbloginpass.Size = new System.Drawing.Size(209, 32);
            this.tbloginpass.TabIndex = 4;
            // 
            // tbloginname
            // 
            this.tbloginname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbloginname.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbloginname.Location = new System.Drawing.Point(38, 117);
            this.tbloginname.Multiline = true;
            this.tbloginname.Name = "tbloginname";
            this.tbloginname.Size = new System.Drawing.Size(209, 32);
            this.tbloginname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox tbloginpass;
        private System.Windows.Forms.TextBox tbloginname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkboxshowpass;
        private System.Windows.Forms.ComboBox cmboxsubject;
        private System.Windows.Forms.Label label4;
    }
}