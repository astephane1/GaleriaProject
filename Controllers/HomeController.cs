using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GaleriaProject.Models;
using MongoDB.Driver;
using Microsoft.IdentityModel.Protocols;
using Microsoft.AspNetCore.Http;
using System.Web;

namespace GaleriaProject.Controllers
{
    public class HomeController : Controller
    {
      private readonly Category category;
        private readonly Artwork artwork;
        private readonly Comment com;
        public HomeController(Category category, Artwork artwork, Comment com)
        {
            this.category = category;
            this.artwork = artwork;
            this.com = com;
        }

        public IActionResult Index()
        { try
            {
                return View(category.Get());
            }
            catch(Exception e)
            {
                ViewData["e"] = e;
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult ResultSearch(string SearchText)
        {

            List<Category> model = category.Get();
           
                if (!string.IsNullOrEmpty(SearchText))
                {
                    var result = model.Where(s => s.Name_Category.Contains(SearchText));
                    return View("ResultSearch", result.ToList());
                }
                return View(model);
     
        }


        public IActionResult AllCategory()
        {
            try
            {
                return View(category.Get());
            }
            catch (Exception e)
            {
                ViewData["e"] = e;
                return View("Error");
            }
        }

       [HttpGet]
        public IActionResult ViewArt(string id)
        {
            int Total = artwork.GetTotal(id);
            int TotalLikes = artwork.GetLikes(id);
            try
            {
                if (Total == 0)
                {
                    ViewData["Average"] = 0;
                }
                else
                {
                    double Average = (double)TotalLikes / Total;
                    ViewData["Average"] = Average.ToString("F2");
                }


                return View(artwork.GetArtwork(id));
            }
            catch (Exception e)
            {
                ViewData["e"] = e;
                return View("Error");
            }
        }

        [HttpPost]
        public JsonResult ViewArt(string id, int like)
        {
            int x = like;
            string [] ide = id.Split('/');
            string _id = ide[ide.Length - 1];
            artwork.LikeArtwork(_id, like);
            return Json(_id);

        }


        public IActionResult OnlyCategory(int id)
        {
            try
            {
                ViewData["Name_Category"] = category.GetCategory(id).Name_Category;
                ViewData["Description_Category"] = category.GetCategory(id).Description_Category;
                ViewData["ImageUrl"] = category.GetCategory(id).ImageUrl;

                return View(artwork.GetArt(id));
            }
            catch (Exception e)
            {
                ViewData["e"] = e;
                return View("Error");
            }
        }


        [HttpPost]
        public IActionResult Contact(Comment car)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    com.Create(car);
                    return RedirectToAction(nameof(Index));
                }
                return View(car);
            }
            catch (Exception e)
            {
                ViewData["e"] = e;
                return View("Error");
            }
        }


        [HttpGet]
        public IActionResult Contact()
        {
            try
            {
                return View();
            }
            catch(Exception e)
            {
                ViewData["e"] = e;
                return View("Error");
            }
        }

        public IActionResult Error()
        {
            return View();
        }

    }  
    
}
