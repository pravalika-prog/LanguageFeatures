using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
//IProductSelection cart=new Shoppingcart(new Product { Name="kayak",Price=275},new Product { Name="LifeJacket",Price=48.95M}, new Product
//{
//    Name = "Soccer ball",
//    Price =
//19.50M
//},
//new Product
//{
//    Name = "Corner flag",
//    Price =
//34.95M
//}
//);
//            return View(cart.Names);
            //Shoppingcart cart = new Shoppingcart()
            //{


            //    producting = Product.GetProducts()

            //};
            //Product[] arraytotal = { new Product { Name = "Vijay", Price = 275M }, new Product { Name = "vanaga", Price = 48.95M },new Product { Name = "viyakiran", Price = 234.75M } };


            //// Filterbyprice = cart.Filterbyprice().TotalPrices();
            ////decimal FilterbyName = cart.Filterbyname().TotalPrices();
            //return View( "Index", new string[] { 

            //    $" Filterbyprice: {Filterbyprice:c2} ,FilterbyName:{FilterbyName:c2}" }
            //) ;


            Product[] productarray = {new Product { Name="vjay",Price=275M},new Product{Name="raju",Price=356M}

            };
            decimal arrayTotal = productarray.TotalPrices();

            decimal cartTotal = productarray.TotalPrices();
            return View("Index", new string[] { $"Total:{cartTotal:C2},ArrayTotal:{arrayTotal}" });

        }
    }
}


        //decimal totalcart = Product.TotalPrices();
            //return View("Index", new string[] { $"total:{totalcart:c2}" });
            //            object[] data = new object[] { 275M, 29.95M,
            //"apple", "orange", 100, 10 };
            //            decimal total = 0;
            //            for (int i = 0; i < data.Length; i++)
            //            {
            //                switch (data[i])
            //                {
            //                    case decimal decimalValue:
            //                        total += decimalValue;
            //                        break;
            //                    case int intValue when intValue > 50:
            //                        total += intValue;
            //                        break;
            //                }
            //            }
            // return View("Index", new string[] { $"Total:{total:c2}" } );

            //Dictionary<string, Product> products = new Dictionary<string, Product>()
            //{
            //    ["kayak"] = new Product { Name = "jonson", Price = 145678M },
            //    ["Jacket"] = new Product { Name = "manoku", Price = 123M },

            //};
            //return View( products.Values);
            //string[] names = new string[3];
            //names[0] = "boe";
            //names[1] = "john";
            //names[2] = "bango";

            //return View( new string[] { "boe", "joe", "man" });
            //return View(new String[] { "c#", "Language", "Features" });
            //    List<string> results = new List<string>();
            //    foreach(Product s in Product.GetProducts())
            //    {
            //        string name =  s?.Name??"<No Name>";
            //        decimal ? price = s?.Price?? 0;
            //        string relatedname = s?.Related?.Name??"<None>";
            //        results.Add($"Name: {name},  Related:{relatedname}    Price:{ price:c2}");

            //    }
            //    return View(results);
            //}

   

