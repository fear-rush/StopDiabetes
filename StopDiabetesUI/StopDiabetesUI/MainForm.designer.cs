namespace StopDiabetes2
{
    partial class SDForm
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
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lblSugar = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbSugar = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lblSaran = new System.Windows.Forms.Label();
            this.tbHasil = new System.Windows.Forms.TextBox();
            this.tbSaran = new System.Windows.Forms.TextBox();
            this.btnSehat = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(309, 108);
            this.tbAge.Multiline = true;
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(208, 44);
            this.tbAge.TabIndex = 1;
            // 
            // lblSugar
            // 
            this.lblSugar.AutoSize = true;
            this.lblSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugar.Location = new System.Drawing.Point(12, 55);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(279, 32);
            this.lblSugar.TabIndex = 2;
            this.lblSugar.Text = "Gula Darah (mg/dL) :";
            this.lblSugar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(12, 108);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(280, 32);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Umur                           :";
            // 
            // tbSugar
            // 
            this.tbSugar.Location = new System.Drawing.Point(309, 55);
            this.tbSugar.Multiline = true;
            this.tbSugar.Name = "tbSugar";
            this.tbSugar.Size = new System.Drawing.Size(208, 44);
            this.tbSugar.TabIndex = 4;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(309, 168);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(208, 37);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "CEK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasil.Location = new System.Drawing.Point(12, 220);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(94, 32);
            this.lblHasil.TabIndex = 6;
            this.lblHasil.Text = "Hasil :";
            this.lblHasil.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSaran
            // 
            this.lblSaran.AutoSize = true;
            this.lblSaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaran.Location = new System.Drawing.Point(303, 220);
            this.lblSaran.Name = "lblSaran";
            this.lblSaran.Size = new System.Drawing.Size(106, 32);
            this.lblSaran.TabIndex = 7;
            this.lblSaran.Text = "Saran :";
            // 
            // tbHasil
            // 
            this.tbHasil.Location = new System.Drawing.Point(18, 255);
            this.tbHasil.Multiline = true;
            this.tbHasil.Name = "tbHasil";
            this.tbHasil.ReadOnly = true;
            this.tbHasil.Size = new System.Drawing.Size(200, 149);
            this.tbHasil.TabIndex = 8;
            // 
            // tbSaran
            // 
            this.tbSaran.Location = new System.Drawing.Point(309, 255);
            this.tbSaran.Multiline = true;
            this.tbSaran.Name = "tbSaran";
            this.tbSaran.ReadOnly = true;
            this.tbSaran.Size = new System.Drawing.Size(208, 149);
            this.tbSaran.TabIndex = 9;
            this.tbSaran.Text = " ";
            // 
            // btnSehat
            // 
            this.btnSehat.Location = new System.Drawing.Point(18, 168);
            this.btnSehat.Name = "btnSehat";
            this.btnSehat.Size = new System.Drawing.Size(208, 37);
            this.btnSehat.TabIndex = 10;
            this.btnSehat.Text = "TIPS HIDUP SEHAT";
            this.btnSehat.UseVisualStyleBackColor = true;
            this.btnSehat.Click += new System.EventHandler(this.btnSehat_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(18, 424);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(147, 36);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Laporkan Bug";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(18, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 35);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 472);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSehat);
            this.Controls.Add(this.tbSaran);
            this.Controls.Add(this.tbHasil);
            this.Controls.Add(this.lblSaran);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbSugar);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSugar);
            this.Controls.Add(this.tbAge);
            this.Name = "SDForm";
            this.Text = "Stop Diabetes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbSugar;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label lblSaran;
        private System.Windows.Forms.TextBox tbHasil;
        private System.Windows.Forms.TextBox tbSaran;
        private System.Windows.Forms.Button btnSehat;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBack;
    }
}

