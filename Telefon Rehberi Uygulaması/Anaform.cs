using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_Uygulaması
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmYeniKayit frm = new frmYeniKayit();
            frm.Show();
            this.Hide();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            frmListele frm = new frmListele();
            frm.Show();
            this.Hide();
        }

        private void Anaform_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader dosya = File.OpenText("veriler.txt");
                dosya.Close();
            }
            catch (Exception)
            {
                StreamWriter dosya = File.CreateText("veriler.txt");// yeni dosya oluştur.
                dosya.Close();
            }
        }

        private void Anaform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
