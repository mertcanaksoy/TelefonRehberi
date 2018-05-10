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
    public partial class frmYeniKayit : Form
    {
        public frmYeniKayit()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            rbtnAdK.Checked = false;
            rbtnAdM.Checked = false;
            rbtnAdY.Checked = false;
            rbtnSoyadK.Checked = false;
            rbtnSoyadM.Checked = false;
            rbtnSoyadY.Checked = false;
            rbtnTelefonK.Checked = false;
            rbtnTelefonM.Checked = false;
            rbtnTelefonY.Checked = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //textbox kontrolü
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTelefon.Text == "")
            {
                MessageBox.Show("Ad,Soyad ve Telefon Bilgilerini Eksiksiz Doldurun", "Eksik Bilgi Girişi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //radioButton kontrolü    
            else if ((rbtnAdK.Checked == false && rbtnAdM.Checked == false && rbtnAdY.Checked == false) || (rbtnSoyadK.Checked == false && rbtnSoyadM.Checked == false && rbtnSoyadY.Checked == false) || (rbtnTelefonK.Checked == false && rbtnTelefonM.Checked == false && rbtnTelefonY.Checked == false))
            {
                MessageBox.Show("Lütfen Ad, Soyad ve Telefon Bilgilerinin Renklerini Giriniz", "Eksik Renk Girişi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Kontrollerin ardından dosyaya yazma
            else
            {
                char[] renkler = new char[3];
                #region RadioButton'lardan renkleri çekip diziye atama işlemleri
                if (rbtnAdK.Checked)
                    renkler[0] = 'k';
                if (rbtnAdM.Checked)
                    renkler[0] = 'm';
                if (rbtnAdY.Checked)
                    renkler[0] = 'y';
                if (rbtnSoyadK.Checked)
                    renkler[1] = 'k';
                if (rbtnSoyadM.Checked)
                    renkler[1] = 'm';
                if (rbtnSoyadY.Checked)
                    renkler[1] = 'y';
                if (rbtnTelefonK.Checked)
                    renkler[2] = 'k';
                if (rbtnTelefonM.Checked)
                    renkler[2] = 'm';
                if (rbtnTelefonY.Checked)
                    renkler[2] = 'y';
                #endregion

                string renk = new string(renkler); //RadioButton'lardan gelen renkleri bir string'te bir araya getir
                StreamWriter dosya = File.AppendText("veriler.txt"); //Dosyayı yazmak için aç
                dosya.WriteLine(renk + " " + txtAd.Text + " " + txtSoyad.Text + " " + txtTelefon.Text); // dosya.WriteLine ile dosyaya renk, ad, soyad ve telefon değerlerini ekle
                dosya.Close(); // Dosyayı kapat

                MessageBox.Show("Rehber Kaydı Başarıyla Gerçekleştirildi", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frmYeniKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anaform frm = new Anaform();
            frm.Show();
        }
    }
}
