using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtension
    {
        //public static decimal Totalprices(this Shoppingcart cartparam) through IEnumerable
        //{
        //        decimal total = 0;
        //        foreach(Product prod in cartparam.producting)
        //        {
        //            total += prod?.Price ?? 0;
        //        }
        //        return total;
        //    }
        public static decimal TotalPrices(this List<Product> producting)
        {
            decimal Total = 0;
            foreach (Product prod in producting)
            {
                Total += prod?.Price ?? 0;
            }
            return Total;
        }
        //        public static IEnumerable<Product> Filterbyprice(this IEnumerable<Product> productenum, decimal minimumprice)
        //        {
        //            foreach (Product prod in productenum)
        //            {
        //                if ((prod?.Price ?? 0) >= minimumprice)
        //                {
        //                    yield return prod;
        //                }

        //            }
        //        }
        //        public static IEnumerable<Product> Filterbyname(this IEnumerable<Product> productenum, char firstletter)
        //        {
        //            foreach (Product prod in productenum)
        //            {
        //                if ((prod?.Name?[0]) == firstletter)
        //                {
        //                    yield return prod;
        //                }
        //           }
        //        }
        //        public static IEnumerable<Product>Filter(this IEnumerable<Product> productenum, Func<Product, bool> selector)
        //        {
        //foreach(Product prod in productenum)
        //            {
        //                if(selector(prod))
        //                {
        //            yield return prod;
        //        }
        //    }
    }
}
  

    
