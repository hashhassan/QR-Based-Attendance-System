namespace AP_Project
{
    partial class AtendReports
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbaridatend = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbsubattend = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnviewatend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btngenreport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Arid No:";
            // 
            // tbaridatend
            // 
            this.tbaridatend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaridatend.Location = new System.Drawing.Point(189, 31);
            this.tbaridatend.Multiline = true;
            this.tbaridatend.Name = "tbaridatend";
            this.tbaridatend.Size = new System.Drawing.Size(149, 27);
            this.tbaridatend.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 306);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Subject:";
            // 
            // cmbsubattend
            // 
            this.cmbsubattend.FormattingEnabled = true;
            this.cmbsubattend.Location = new System.Drawing.Point(189, 80);
            this.cmbsubattend.Name = "cmbsubattend";
            this.cmbsubattend.Size = new System.Drawing.Size(149, 21);
            this.cmbsubattend.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(453, 166);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(420, 306);
            this.dataGridView2.TabIndex = 11;
            // 
            // btnviewatend
            // 
            this.btnviewatend.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewatend.Location = new System.Drawing.Point(189, 118);
            this.btnviewatend.Name = "btnviewatend";
            this.btnviewatend.Size = new System.Drawing.Size(149, 42);
            this.btnviewatend.TabIndex = 12;
            this.btnviewatend.Text = "View Attendance";
            this.btnviewatend.UseVisualStyleBackColor = true;
            this.btnviewatend.Click += new System.EventHandler(this.btnviewatend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "View Overall Report:";
            // 
            // btngenreport
            // 
            this.btngenreport.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenreport.Location = new System.Drawing.Point(588, 118);
            this.btngenreport.Name = "btngenreport";
            this.btngenreport.Size = new System.Drawing.Size(149, 42);
            this.btngenreport.TabIndex = 14;
            this.btngenreport.Text = "Generate Report";
            this.btngenreport.UseVisualStyleBackColor = true;
            this.btngenreport.Click += new System.EventHandler(this.btngenreport_Click);
            // 
            // AtendReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 516);
            this.ControlBox = false;
            this.Controls.Add(this.btngenreport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnviewatend);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cmbsubattend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbaridatend);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AtendReports";
            this.Text = "AtendReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AtendReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbaridatend;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbsubattend;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnviewatend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngenreport;
    }
}