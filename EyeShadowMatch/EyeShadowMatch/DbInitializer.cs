using EyeShadowMatch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EyeShadowMatch
{
    public class DbInitializer : DropCreateDatabaseAlways<EyeshadowMatchContext>
    {
        protected override void Seed(EyeshadowMatchContext context)
        {
            var brands = new List<Brand>()
            {
                new Brand(){BrandName = "NARS"},
                new Brand(){BrandName = "MAC"},
                new Brand(){BrandName = "Dior"},
                new Brand(){BrandName = "Tom Ford"},
                new Brand(){BrandName = "Yves Saint Laurent"},
                new Brand(){BrandName = "CHANEL"},
                new Brand(){BrandName = "Bobbi Brown"}
            };
            context.Brands.AddRange(brands);
            context.SaveChanges();

        }
    }
}