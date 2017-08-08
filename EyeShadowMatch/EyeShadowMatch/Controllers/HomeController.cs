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


//public ActionResult Create(Recipe recipe)
//{
//    if (ModelState.IsValid)
//    {

//        if (recipe.File1.ContentLength > (2 * 1024 * 1024))
//        {
//            ModelState.AddModelError("CustomError", "File size must be less than 2 MB");
//            return View();
//        }
//        if (!(recipe.File1.ContentType == "image/jpeg" || recipe.File1.ContentType == "image/gif"))
//        {
//            ModelState.AddModelError("CustomError", "File type allowed : jpeg and gif");
//            return View();
//        }

//        recipe.File1Name = recipe.File1.FileName;
//        recipe.Image1Size = recipe.File1.ContentLength;

//        byte[] data = new byte[recipe.File1.ContentLength];
//        recipe.File1.InputStream.Read(data, 0, recipe.File1.ContentLength);

//        recipe.Image1Data = data;


//        if (recipe.File2.ContentLength > (2 * 1024 * 1024))
//        {
//            ModelState.AddModelError("CustomError", "File size must be less than 2 MB");
//            return View();
//        }
//        if (!(recipe.File2.ContentType == "image/jpeg" || recipe.File2.ContentType == "image/gif"))
//        {
//            ModelState.AddModelError("CustomError", "File type allowed : jpeg and gif");
//            return View();
//        }

//        recipe.File2Name = recipe.File2.FileName;
//        recipe.Image2Size = recipe.File2.ContentLength;

//        byte[] data2 = new byte[recipe.File2.ContentLength];
//        recipe.File2.InputStream.Read(data2, 0, recipe.File2.ContentLength);

//        recipe.Image2Data = data2;


//        db.Recipes.Add(recipe);
//        db.SaveChanges();
//        return RedirectToAction("Index", "RecipeStep", new { recipeID = recipe.RecipeID });
//    }
//    ViewBag.RecipeCategoryID = new SelectList(db.RecipeCategories, "RecipeCategoryID", "RecipeCategoryName", recipe.RecipeCategoryID);
//    return View(recipe);
//}