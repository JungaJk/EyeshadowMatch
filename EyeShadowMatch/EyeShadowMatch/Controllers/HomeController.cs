using EyeShadowMatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EyeShadowMatch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (var ctx = new EyeshadowMatchContext())
            {
                Brand brand = new Brand() { BrandName = "MAC" };

                ctx.Brands.Add(brand);
                ctx.SaveChanges();
            }

            return View();
        }
    }
}