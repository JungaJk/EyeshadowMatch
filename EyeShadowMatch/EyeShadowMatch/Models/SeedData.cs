using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EyeShadowMatch.Models
{
    public static class SeedData
    {
        public static void EnsureSeedDataForContext(this EyeshadowMatchContext context)
        {
            var brands = new List<Brand>()
            {
                new Brand()
                {
                    BrandName = "NARS"
                },
                   new Brand()
                {
                    BrandName = "MAC"
                }

            };

            var products = new List<Product>()
            {
                new Product()
                {
                    ProductName="",
                    BrandId = 1,
                    Price = 33
                }
            };
        }
    }
}