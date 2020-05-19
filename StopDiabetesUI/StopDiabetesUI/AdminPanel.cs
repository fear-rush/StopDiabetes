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
using System.Data.Entity;
using StopDiabetesDatabase;

namespace StopDiabetes2
{

    public partial class AdminPanel : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=.\SQLEXPRESS;initial catalog=StopDiabetes;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public AdminPanel()
        {
            InitializeComponent();
            try
            {
                //conn.Open();
                //MessageBox.Show("Selamat datang Admin");
                //DataTable dt = new DataTable();
                //SqlDataAdapter da = new SqlDataAdapter("select * from kritik", conn);
                //da.Fill(dt);
                //dgKritik.DataSource = dt;

                using (ModelContext db = new ModelContext())
                {
                    var query = (from c in db.Laporans
                                 select c).ToList();
                    dgKritik.DataSource = query;


                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Koneksi gagal" + e);
            }
            finally
            {
                conn.Close();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void dgKritik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgKritik.CurrentRow.Index != -1)
            {
                Laporan laporan = new Laporan();
                laporan.Id = Convert.ToInt32(dgKritik.CurrentRow.Cells["Id"].Value);
                ModelContext db = new ModelContext();
                laporan = db.Laporans.
                    Where(x => x.Id == laporan.Id).
                    FirstOrDefault();

                var entry = db.Entry(laporan);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                    db.Laporans.Attach(laporan);
                db.Laporans.Remove(laporan);
                db.SaveChanges();

                var query =
                    (from data in db.Laporans
                     select data).ToList();

                dgKritik.DataSource = query;
                MessageBox.Show("Data terhapus");
            }
            else
                MessageBox.Show("Silakan pilih data yang akan dihapus");
        }
    }
}

        
   
    


