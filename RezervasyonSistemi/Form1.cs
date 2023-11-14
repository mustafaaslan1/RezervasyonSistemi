using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            string adsoyad = txtAdSoyad.Text;
            string kimlik = maskedKimlik.Text;
            string telefon = maskedTelefon.Text;
            string plan1 = comboNereden.Text;
            string plan2 = comboNereye.Text;
            string tarih = dateTimePicker1.Text;
            string saat = maskedSaat.Text;

            if (string.IsNullOrWhiteSpace(adsoyad) || string.IsNullOrWhiteSpace(kimlik) || string.IsNullOrWhiteSpace(telefon)
                || string.IsNullOrWhiteSpace(plan1) || string.IsNullOrWhiteSpace(plan2) || string.IsNullOrWhiteSpace(tarih) ||
                string.IsNullOrWhiteSpace(saat))
            {
                DialogResult butunislem;
                butunislem = MessageBox.Show("Herhangi bir sekme boş olamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Hide();
                Form2 kayit = new Form2(txtAdSoyad.Text,maskedKimlik.Text,maskedTelefon.Text,comboNereden.Text,comboNereye.Text,dateTimePicker1.Text,maskedSaat.Text);
                kayit.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = comboNereden.Text;
            comboNereden.Text = comboNereye.Text;
            comboNereye.Text = label8.Text;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult kapat;
            kapat = MessageBox.Show("Uygulamayı Kapatmak İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kapat == DialogResult.Yes)
            {
               kapat = MessageBox.Show("Uygulama Kapatılıyor..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (kapat == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else if (kapat == DialogResult.No)
            {
                MessageBox.Show("Uygulama Kapatılmadı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
