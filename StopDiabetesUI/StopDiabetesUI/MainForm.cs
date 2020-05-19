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
    public partial class SDForm : Form
    {
        public bool btnCheckClicked;

        public SDForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (tbSugar.Text == "" && tbAge.Text == "")
            {
                Calculate calculate = new Calculate();
                MessageBox.Show(calculate.displayError());
            }
            else
            {
                Calculate calculate = new Calculate();
                calculate.calculate(int.Parse(tbSugar.Text), int.Parse(tbAge.Text));

                Hasil hasil = new Hasil();
                tbHasil.Text = hasil.outputHasil(calculate);
                Saran saran = new Saran();
                tbSaran.Text = saran.outputSaran(calculate);
                btnCheckClicked = true;
            }
           
        }

        private void btnSehat_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            if (btnCheckClicked == true)
            {
                TipsSehatForm tipssehatform = new TipsSehatForm();
                tipssehatform.Show();


                calculate.calculate(int.Parse(tbSugar.Text), int.Parse(tbAge.Text));

                Hasil hasil = new Hasil();
                hasil.outputHasil(calculate);
                TipsSehat tipssehat = new TipsSehat();


                tipssehatform.tbSehat.Text = tipssehat.displayTips(hasil);
            }
            else
            {
                MessageBox.Show("Silakan anda lakukan cek gula darah terlebih dahulu");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportBug reportbug = new ReportBug();
            reportbug.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
