using ödev.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public string Id = "0";
        private Kullanici kullanici = new Kullanici();

        private void onaylabutton_Click(object sender, EventArgs e)
        {
            if (Id == "0")
            {
                var sonuc = Business.KayıtOl(adtextBox.Text, soyadtextBox.Text, txtNumara.Text, tckimliktextBox.Text, adrestextBox.Text);
                if (sonuc)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı oluşamadı!");
                }
            }
            else
            {
                kullanici.AdSoyad = adtextBox.Text;
                kullanici.Eposta = soyadtextBox.Text;
                kullanici.Numara = txtNumara.Text;
                kullanici.Sifre = tckimliktextBox.Text;
                kullanici.Adres = adrestextBox.Text;
                var sonuc = Business.KullaniciGuncelle(kullanici);
                if (sonuc)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı oluşamadı!");
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (Id != "0")
            {
                kullanici = Business.Kullanici(Id);
                adtextBox.Text = kullanici.AdSoyad;
                soyadtextBox.Text = kullanici.Eposta;
                txtNumara.Text = kullanici.Numara;
                tckimliktextBox.Text = kullanici.Sifre;
                adrestextBox.Text = kullanici.Adres;
            }
        }
    }
}
