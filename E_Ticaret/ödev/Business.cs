using ödev.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    public class Business
    {
        public static string GirisYap(string eposta, string sifre)
        {
            var kullanici = new Kullanici()
            {
                Eposta = eposta,
                Sifre = sifre
            };
            return DataAccess.GirisYap(kullanici);
        }

        public static bool KayıtOl(string adSoyad, string eposta, string numara, string sifre, string adres)
        {
            var kullanici = new Kullanici()
            {
                Id = Guid.NewGuid(),
                AdSoyad = adSoyad,
                Eposta = eposta,
                Numara = numara,
                Sifre = sifre,
                Adres = adres
            };
            var sonuc = DataAccess.KayitOl(kullanici);
            if (sonuc != -1)
            {
                return true;
            }
            return false;
        }

        public static void SepetteArttır(string urunId, string kullaniciId)
        {
            var sepetUrunler = DataAccess.KullaniciSepet(Guid.Parse(kullaniciId));
            var sepet = sepetUrunler.Where(x => x.UrunId == Guid.Parse(urunId)).FirstOrDefault();
            var yeniSepet = new Sepet();
            if (sepet != null)
            {
                sepet.Adet++;
                DataAccess.AdetGuncele(sepet);
            }
            else
            {
                yeniSepet.Id = Guid.NewGuid();
                yeniSepet.KullaniciId = Guid.Parse(kullaniciId);
                yeniSepet.UrunId = Guid.Parse(urunId);
                yeniSepet.Adet = 1;
                DataAccess.SepeteEkle(yeniSepet);
            }
        }

        public static void SepetteAzalt(string urunId, string kullaniciId)
        {
            var sepetUrunler = DataAccess.KullaniciSepet(Guid.Parse(kullaniciId));
            var sepet = sepetUrunler.Where(x => x.UrunId == Guid.Parse(urunId)).FirstOrDefault();
            var yeniSepet = new Sepet();
            if (sepet != null)
            {
                sepet.Adet--;
                if (sepet.Adet == 0)
                {
                    DataAccess.SepettenSil(sepet);
                }
                else
                {
                    DataAccess.AdetGuncele(sepet);
                }
            }
        }

        public static Kullanici Kullanici(string id)
        {
            return DataAccess.KullaniciById(Guid.Parse(id));
        }

        public static bool KullaniciGuncelle(Kullanici kullanici)
        {
            var sonuc = DataAccess.KullaniciGuncelle(kullanici);
            if (sonuc != -1)
            {
                return true;
            }
            return false;
        }

        public static List<SepetListe> KullaniciSepeti(string id)
        {
            var sepet = DataAccess.KullaniciSepet(Guid.Parse(id));
            List<SepetListe> liste = new List<SepetListe>();
            foreach(var sepetUrun in sepet)
            {
                var urun = DataAccess.UrunById(sepetUrun.UrunId);
                liste.Add(new SepetListe
                {
                    UrunAd = urun.Ad,
                    Fiyat = urun.Fiyat,
                    Adet = sepetUrun.Adet,
                });
            }
            return liste;
        }
    }
}
