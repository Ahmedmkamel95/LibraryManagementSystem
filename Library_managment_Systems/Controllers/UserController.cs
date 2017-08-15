using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LMS_Core.Business;
using LMS_model;
namespace Library_managment_Systems.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        //
        UserBL x = new UserBL();
        
        // GET: /User/


        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return View(model);

        }
	}
}