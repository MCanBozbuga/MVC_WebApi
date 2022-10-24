using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_GoogleAuth.Models
{
    public partial class SatisRaporu
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Müşteri { get; set; }
        public string Kategori { get; set; }
        public string Ürün { get; set; }
        public decimal Fiyat { get; set; }
        public short Adet { get; set; }
    }
}
