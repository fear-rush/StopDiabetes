using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StopDiabetesLibrary;
using System.Data.OleDb;
using System.Data.SqlClient;
using StopDiabetesDB;
using System.Data.Entity;
namespace StopDiabetes2
{
    
    public partial class ReportBug : Form
    {
        //SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=SdContext;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");


        public ReportBug()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into Laporan (Nama, Email, Kritik) values(@1,@2,@3)", conn);
            //cmd.Parameters.AddWithValue("@1", tbNama.Text);
            //cmd.Parameters.AddWithValue("@2", tbEmail.Text);
            //cmd.Parameters.AddWithValue("@3", tbReport.Text);
            //cmd.ExecuteScalar();


            //conn.Close();
            if (tbNama.Text != "" && tbEmail.Text != "" && tbReport.Text != "")
            {
                using (ModelContext db = new ModelContext())
                {
                    Laporan laporan = new Laporan()
                    {
                        Nama = tbNama.Text,
                        Email = tbEmail.Text,
                        Kritik = tbReport.Text,
                        Tanggal = DateTime.Now
                    };
                    db.Laporan.Add(laporan);
                    db.SaveChanges();
                    MessageBox.Show("Terimakasih telah melaporkan bug ini");

                }
            }
            else
            {
                MessageBox.Show("Nama, Email, dan Kritik harus diisi");
            }
        }

        private void btnCloseReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void ReportBug_Load(object sender, EventArgs e)
        {

        }
    }
}
