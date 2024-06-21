using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev.Entity
{
    public class Kullanici
    {
        public Guid Id { get; set; }
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }
        public string Numara { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
    }
}
