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

namespace StopDiabetes2
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            if(admin.PasswordValid(tbUsername.Text, tbPassword.Text))
            {
                AdminPanel adminpanel = new AdminPanel();
                adminpanel.Show();

               
               
                
            }
            else
            {
                MessageBox.Show("Username atau Password salah !");
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
