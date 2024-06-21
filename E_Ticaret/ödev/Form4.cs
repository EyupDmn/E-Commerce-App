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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string Id = "0";

        private void Form4_Load(object sender, EventArgs e)
        {
            float toplam = 0.0f;
            if(Id != "0")
            {
                var sepet = Business.KullaniciSepeti(Id);
                listSepet.Items.Clear();
                foreach(var urun in sepet)
                {
                    var veri = new ListViewItem(
                        new string[] { urun.UrunAd, urun.Fiyat, urun.Adet.ToString() }
                        );
                    listSepet.Items.Add(veri);
                    var fiyat = float.Parse(urun.Fiyat.Remove(urun.Fiyat.Length - 2));
                    toplam += fiyat * urun.Adet;
                }
                lblToplamFiyat.Text = toplam.ToString();
            }
        }

        private void devametbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Id ="0";
            this.Close();
        }

        private void hesapAyarlarıToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Id = Id;
            form.ShowDialog();
        }
    }
}
