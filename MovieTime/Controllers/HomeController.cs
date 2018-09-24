using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTime.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var db = new Models.Database())
            {
                List<Models.Movie> allMovies = db.Movie.ToList();
                return View(allMovies);
            }
            //return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Models.Customer inCustomer)
        {
            using (var db = new Models.Database())
            {
                try
                {
                    db.Customer.Add(inCustomer);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    //Must add something here
                }
            }
            return RedirectToAction("Index");
        }
    }
}