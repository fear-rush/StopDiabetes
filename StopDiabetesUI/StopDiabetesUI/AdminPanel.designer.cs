namespace StopDiabetes2
{
    partial class AdminPanel
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
            this.dgKritik = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClosePanel = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKritik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKritik
            // 
            this.dgKritik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKritik.Location = new System.Drawing.Point(12, 44);
            this.dgKritik.Name = "dgKritik";
            this.dgKritik.RowHeadersWidth = 62;
            this.dgKritik.RowTemplate.Height = 28;
            this.dgKritik.Size = new System.Drawing.Size(875, 357);
            this.dgKritik.TabIndex = 0;
            this.dgKritik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKritik_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kumpulan Bug Report";
            // 
            // btnClosePanel
            // 
            this.btnClosePanel.Location = new System.Drawing.Point(248, 407);
            this.btnClosePanel.Name = "btnClosePanel";
            this.btnClosePanel.Size = new System.Drawing.Size(137, 38);
            this.btnClosePanel.TabIndex = 2;
            this.btnClosePanel.Text = "Close";
            this.btnClosePanel.UseVisualStyleBackColor = true;
            this.btnClosePanel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(526, 407);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(137, 38);
            this.btHapus.TabIndex = 3;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 457);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btnClosePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgKritik);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKritik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKritik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClosePanel;
        private System.Windows.Forms.Button btHapus;
    }
}