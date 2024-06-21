using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev.Entity
{
    public class Sepet
    {
        public Guid Id { get; set; }
        public Guid KullaniciId { get; set; }
        public Guid UrunId { get; set; }
        public int Adet { get; set; }
    }
}
