using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopDiabetes2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPengguna_Click(object sender, EventArgs e)
        {
            
            SDForm sdform = new SDForm();
            sdform.Show();
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin adminlogin = new AdminLogin();
            adminlogin.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
