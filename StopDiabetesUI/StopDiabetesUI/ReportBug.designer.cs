namespace StopDiabetes2
{
    partial class ReportBug
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
            this.lblNama = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.btnCloseReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(12, 28);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(83, 29);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama ";
            this.lblNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(165, 253);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 38);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(165, 32);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(326, 26);
            this.tbNama.TabIndex = 2;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(12, 128);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(131, 29);
            this.lblReport.TabIndex = 3;
            this.lblReport.Text = "Isi Laporan";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 29);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(165, 79);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(326, 26);
            this.tbEmail.TabIndex = 5;
            // 
            // tbReport
            // 
            this.tbReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbReport.Location = new System.Drawing.Point(165, 132);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(326, 103);
            this.tbReport.TabIndex = 6;
            this.tbReport.Text = "(Max 200 Huruf)";
            // 
            // btnCloseReport
            // 
            this.btnCloseReport.Location = new System.Drawing.Point(375, 253);
            this.btnCloseReport.Name = "btnCloseReport";
            this.btnCloseReport.Size = new System.Drawing.Size(116, 38);
            this.btnCloseReport.TabIndex = 7;
            this.btnCloseReport.Text = "Close";
            this.btnCloseReport.UseVisualStyleBackColor = true;
            this.btnCloseReport.Click += new System.EventHandler(this.btnCloseReport_Click);
            // 
            // ReportBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 330);
            this.Controls.Add(this.btnCloseReport);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblNama);
            this.Name = "ReportBug";
            this.Text = "ReportBug";
            this.Load += new System.EventHandler(this.ReportBug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Button btnCloseReport;
    }
}