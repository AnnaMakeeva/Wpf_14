using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_14
{
    public enum ProductTypes
    {
        Food,
        Appliances
    }

    public class Product
    {
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public string ProductImage { get; set; }
        public ProductTypes ProductType { get; set; }

        public override string ToString()
        {
            return NameProduct;
        }

    }
}
