
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieTime.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.LoginCustomer User)
        {
            using (var db = new Models.Database())
            {
                try
                {
                    var v = db.Customer.Where(a => a.Username.Equals(User.Username) && a.Password.Equals(User.Password)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["LogedUserID"] = v.Username.ToString();
                        return RedirectToAction("Index", "Home", new { area = "" });
                    }
             
                }
                catch (Exception ex)
                {
                    //Must add something here
                }
            }
            return RedirectToAction("IfLoginFails");
        }

        public ActionResult IfLoginFails()
        {
            return View();
        }
    }
}