using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        //public Product ( bool stock=true){
        //   Instock=stock;
        //    }

        public string  Name { get; set; }
        public string Category { get; set; } = "Watersports";
       public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool Instock { get; }
        public static Product[] GetProducts()
        {
            Product Kayak = new Product()
            {
                Name = "Kayak",
                Price = 275M
            };
            Product Jacket = new Product()
            {
                Name = "Jacket",
                Price = 48.95M
            };
            Kayak.Related = Jacket;
            Jacket.Related = Kayak;
            return new Product[] { Kayak, Jacket };
        }
        //public static decimal TotalPrices()
        //{
        //    decimal Total = 0;
        //    foreach (Product prod in Product.GetProducts())
        //    {
        //        Total += prod?.Price ?? 0;
        //    }
        //    return Total;
        //}

    }
}

