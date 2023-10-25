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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Uçuş Rotası: " + comboBox1.Text + " - " + comboBox2.Text +
                " Tarih: "  + dateTimePicker1.Text + 
                " Saat: " + maskedTextBox1.Text +
                " // Yolcu Bilgileri // İsim Soyisim: " + textBox1.Text + 
                " TC Kimlik Numarası:" + maskedTextBox2.Text + 
                " Telefon Numarası:" +maskedTextBox3.Text);
            MessageBox.Show("Kayıt işleminiz başarı ile yapılmıştır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label8.Text;

        }
    }
}
