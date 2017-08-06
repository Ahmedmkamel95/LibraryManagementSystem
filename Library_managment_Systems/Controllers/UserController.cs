using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LMS_model;
using LMS_Core;
namespace Library_managment_Systems.Controllers
{
    public class UserController : Controller
    {
        //
        User user = new User();
        
        // GET: /User/


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login(User model)
        {
            int check = user.login(model);
            if (check != 0)
            {
                //    TempData["id"] = model.user_id;
                return RedirectToAction("Index", "Home", new { id = check });
            }
            else
                return RedirectToAction("login");

        }

        

	}
}