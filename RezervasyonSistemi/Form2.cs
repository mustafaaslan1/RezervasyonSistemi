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
    public partial class Form2 : Form
    {
        public Form2(string s, string s1, string s2, string s3, string s4, string s5, string s6)
        {
            InitializeComponent();

            listBox1.Items.Add(" İsim Soyisim: " + s);
            listBox1.Items.Add(" Kimlik Numarası: " + s1);
            listBox1.Items.Add(" Telefon Numarası " + s2);

            listBox2.Items.Add(" Nereden: " +s3);
            listBox2.Items.Add(" Nereye: " +s4);
            listBox2.Items.Add(" Uçuş Tarihi: " +s5);
            listBox2.Items.Add(" Uçuş Saati: " +s6);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("İşlemi sonlandırmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (sonuc == DialogResult.No)
            {
                MessageBox.Show("Uygulama Kapatılmadı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
