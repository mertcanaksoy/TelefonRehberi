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
    public partial class frmListele : Form
    {
        public frmListele()
        {
            InitializeComponent();
        }

        private void frmListele_Load(object sender, EventArgs e)
        {
            StreamReader dosya = File.OpenText("veriler.txt");//Stream Reader ile Dosyayı oku
            string s = dosya.ReadLine();//ilk satırı oku
            int satirSayisi = 0;
            string parca = "";

            //satır sayısını öğrenmek ve okunan öğeleri richTextbox'a aktarmak için kullanılan döngü
            while (s != null)//s null olmadığı sürece satırı okutup bir alt satıra geç
            {
                parca += s + "\n"; //txt dosyasındaki satırı parca adlı değişkene ata ve ardından aynı değişkende alt satıra geç
                s = dosya.ReadLine(); //txt dosyasında bir alt satıra geç
                satirSayisi++;
                txtListe.Text = parca;
            }

            string[] bosluklaraGoreBol = parca.Split(' ', '\n');

            for (int i = 0; i < satirSayisi * 4; i = i + 4)
            {
                #region K-M-Y renklendirme

                if (bosluklaraGoreBol[i][0] == 'k')
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i + 1]), bosluklaraGoreBol[i + 1].Length);
                    txtListe.SelectionColor = Color.Red;
                    txtListe.DeselectAll();
                }
                if (bosluklaraGoreBol[i][1] == 'k')
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i + 2]), bosluklaraGoreBol[i + 2].Length);
                    txtListe.SelectionColor = Color.Red;
                    txtListe.DeselectAll();
                }
                if (bosluklaraGoreBol[i][2] == 'k')
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i + 3]), bosluklaraGoreBol[i + 3].Length);
                    txtListe.SelectionColor = Color.Red;
                    txtListe.DeselectAll();
                }

                if (bosluklaraGoreBol[i][0] == 'm')
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i + 1]), bosluklaraGoreBol[i + 1].Length);
                    txtListe.SelectionColor = Color.Blue;
                    txtListe.DeselectAll();
                }
                if (bosluklaraGoreBol[i][1] == 'm')
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i + 2]), bosluklaraGoreBol[i + 2].Length);
                    txtListe.SelectionColor = Color.Blue;
                    txtListe.DeselectAll();
                }
                if (bosluklaraGoreBol[i][2] == 'm')
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i + 3]), bosluklaraGoreBol[i + 3].Length);
                    txtListe.SelectionColor = Color.Blue;
                    txtListe.DeselectAll();
                }

                if (bosluklaraGoreBol[i][0] == 'y')
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i + 1]), bosluklaraGoreBol[i + 1].Length);
                    txtListe.SelectionColor = Color.Green;
                    txtListe.DeselectAll();
                }
                if (bosluklaraGoreBol[i][1] == 'y')
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i + 2]), bosluklaraGoreBol[i + 2].Length);
                    txtListe.SelectionColor = Color.Green;
                    txtListe.DeselectAll();
                }
                if (bosluklaraGoreBol[i][2] == 'y')
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i + 3]), bosluklaraGoreBol[i + 3].Length);
                    txtListe.SelectionColor = Color.Green;
                    txtListe.DeselectAll();
                }

                #endregion
            }

            #region Satırları kalınlaştırma

            if (satirSayisi == 1) //Satır sayısı 1 ise ilk satırı seç ve kalınlaştır
            {
                txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[0]), txtListe.Text.LastIndexOf(bosluklaraGoreBol[4]));
                txtListe.SelectionFont = new Font(txtListe.Font, FontStyle.Bold);
                txtListe.DeselectAll();
            }

            if (satirSayisi > 1 || satirSayisi < 3)
            {
                for (int i = 0; i < satirSayisi * 4; i = i + 8) //Tek numaralı satırları kalın çift numaralı satırları ince yapan döngü
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i]), txtListe.Text.IndexOf(bosluklaraGoreBol[i + 4]));
                    txtListe.SelectionFont = new Font(txtListe.Font, FontStyle.Bold);
                    txtListe.DeselectAll();

                }

                if (satirSayisi % 2 == 1) //Herhangi bir hata oluşmaması için eğer satır sayısı tekse son satırı bold hale getirmek için kullanılan koşul ve döngü
                {
                    for (int i = satirSayisi * 4 - 4; i < satirSayisi * 4; i = i + 4)
                    {
                        txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i]), txtListe.Text.IndexOf(bosluklaraGoreBol[i]));
                        txtListe.SelectionFont = new Font(txtListe.Font, FontStyle.Bold);
                        txtListe.DeselectAll();
                    }
                }

            }

            if (satirSayisi > 3)
            {
                for (int i = 0; i < satirSayisi * 4; i = i + 8) //Tek numaralı satırları kalın çift numaralı satırları ince yapan döngü
                {
                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i]), txtListe.Text.IndexOf(bosluklaraGoreBol[i + 4]));
                    txtListe.SelectionFont = new Font(txtListe.Font, FontStyle.Bold);
                    txtListe.DeselectAll();

                    txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i + 4]), txtListe.Text.IndexOf(bosluklaraGoreBol[i + 4]));
                    txtListe.SelectionFont = new Font(txtListe.Font, FontStyle.Regular);
                    txtListe.DeselectAll();
                }


                if (satirSayisi % 2 == 0) //Herhangi bir hata oluşmaması için eğer satır sayısı çiftse son satırı regular hale getirmek için kullanılan koşul ve döngü
                {
                    for (int i = satirSayisi * 4 - 4; i < satirSayisi * 4; i = i + 4)
                    {
                        txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i]), txtListe.Text.IndexOf(bosluklaraGoreBol[i]));
                        txtListe.SelectionFont = new Font(txtListe.Font, FontStyle.Regular);
                        txtListe.DeselectAll();
                    }
                }

                if (satirSayisi % 2 == 1) //Herhangi bir hata oluşmaması için eğer satır sayısı çiftse son satırı regular hale getirmek için kullanılan koşul ve döngü
                {
                    for (int i = satirSayisi * 4 - 4; i < satirSayisi * 4; i = i + 4)
                    {
                        txtListe.Select(txtListe.Text.IndexOf(bosluklaraGoreBol[i]), txtListe.Text.IndexOf(bosluklaraGoreBol[i]));
                        txtListe.SelectionFont = new Font(txtListe.Font, FontStyle.Bold);
                        txtListe.DeselectAll();
                    }
                }
            }

            #endregion



            dosya.Close();//Dosyayı kapat
        }

        private void frmListele_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anaform frm = new Anaform();
            frm.Show();
        }
    }
}
