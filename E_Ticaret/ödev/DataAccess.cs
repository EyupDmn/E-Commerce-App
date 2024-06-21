using ödev.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    public class DataAccess
    {
        static SqlConnection baglanti = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DUMAN\Desktop\Eyüp_Duman_Safa_Murat_2Ö\E_Ticaret\ödev\odevDB.mdf;Integrated Security=True"
            );

        public static string GirisYap(Kullanici kullanici)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                var select = "select * from kullanicilar where eposta = '" + kullanici.Eposta + "' AND sifre = '" + kullanici.Sifre + "'";
                var komut = new SqlCommand(select, baglanti);

                var reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    return reader[0].ToString();
                }
                return "0";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                throw;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int KayitOl(Kullanici kullanici)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                var insert = "insert into kullanicilar values(@Id, @AdSoyad, @Eposta, @Numara, @Sifre, @Adres)";
                var komut = new SqlCommand(insert, baglanti);

                komut.Parameters.AddWithValue("@Id", kullanici.Id.ToString());
                komut.Parameters.AddWithValue("@AdSoyad", kullanici.AdSoyad);
                komut.Parameters.AddWithValue("@Eposta", kullanici.Eposta);
                komut.Parameters.AddWithValue("@Numara", kullanici.Numara);
                komut.Parameters.AddWithValue("@Sifre", kullanici.Sifre);
                komut.Parameters.AddWithValue("@Adres", kullanici.Adres);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                throw;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static List<Sepet> KullaniciSepet(Guid kullaniciId)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                var select = "select * from sepet where kullanici_id = '" + kullaniciId.ToString() + "'";
                var komut = new SqlCommand(select, baglanti);

                var reader = komut.ExecuteReader();
                List<Sepet> sepet = new List<Sepet>();
                while (reader.Read())
                {
                    sepet.Add(new Sepet()
                    {
                        Id = Guid.Parse(reader[0].ToString()),
                        KullaniciId = Guid.Parse(reader[1].ToString()),
                        UrunId = Guid.Parse(reader[2].ToString()),
                        Adet = int.Parse(reader[3].ToString()),
                    });
                }
                return sepet;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                throw;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int AdetGuncele(Sepet sepet)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                var update = "update sepet set kullanici_id = @KullaniciId, urun_id = @UrunId, adet = @Adet where id = @Id";
                var komut = new SqlCommand(update, baglanti);

                komut.Parameters.AddWithValue("@Id", sepet.Id.ToString());
                komut.Parameters.AddWithValue("@KullaniciId", sepet.KullaniciId);
                komut.Parameters.AddWithValue("@UrunId", sepet.UrunId);
                komut.Parameters.AddWithValue("@Adet", sepet.Adet);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                throw;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int SepeteEkle(Sepet sepet)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                var insert = "insert into sepet values(@Id, @KullaniciId, @UrunId, @Adet)";
                var komut = new SqlCommand(insert, baglanti);

                komut.Parameters.AddWithValue("@Id", sepet.Id.ToString());
                komut.Parameters.AddWithValue("@KullaniciId", sepet.KullaniciId);
                komut.Parameters.AddWithValue("@UrunId", sepet.UrunId);
                komut.Parameters.AddWithValue("@Adet", sepet.Adet);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                throw;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int SepettenSil(Sepet sepet)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                var delete = "delete from sepet where id = @Id)";
                var komut = new SqlCommand(delete, baglanti);

                komut.Parameters.AddWithValue("@Id", sepet.Id.ToString());

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                throw;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static Kullanici KullaniciById(Guid id)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                var select = "select * from kullanicilar where id = '" + id.ToString() + "'";
                var komut = new SqlCommand(select, baglanti);

                var reader = komut.ExecuteReader();
                reader.Read();
                var kullanici = new Kullanici()
                {
                    Id = Guid.Parse(reader[0].ToString()),
                    AdSoyad = reader[1].ToString(),
                    Eposta = reader[2].ToString(),
                    Numara = reader[3].ToString(),
                    Sifre = reader[4].ToString(),
                    Adres = reader[5].ToString(),
                };
                return kullanici;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                throw;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int KullaniciGuncelle(Kullanici kullanici)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                var update = "update kullanicilar set ad_soyad = @AdSoyad, eposta = @Eposta, numara = @Numara, sifre = @Sifre, adres = @Adres where id = @Id";
                var komut = new SqlCommand(update, baglanti);

                komut.Parameters.AddWithValue("@Id", kullanici.Id.ToString());
                komut.Parameters.AddWithValue("@AdSoyad", kullanici.AdSoyad);
                komut.Parameters.AddWithValue("@Eposta", kullanici.Eposta);
                komut.Parameters.AddWithValue("@Numara", kullanici.Numara);
                komut.Parameters.AddWithValue("@Sifre", kullanici.Sifre);
                komut.Parameters.AddWithValue("@Adres", kullanici.Adres);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                throw;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static Urun UrunById(Guid id)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                var select = "select * from urunler where id = '" + id.ToString() + "'";
                var komut = new SqlCommand(select, baglanti);

                var reader = komut.ExecuteReader();
                reader.Read();
                var kullanici = new Urun()
                {
                    Id = Guid.Parse(reader[0].ToString()),
                    Ad = reader[1].ToString(),
                    Fiyat = reader[2].ToString()
                };
                return kullanici;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                throw;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }
    }
}
