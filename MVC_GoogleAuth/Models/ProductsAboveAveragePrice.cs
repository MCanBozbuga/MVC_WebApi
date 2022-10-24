using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_GoogleAuth.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
