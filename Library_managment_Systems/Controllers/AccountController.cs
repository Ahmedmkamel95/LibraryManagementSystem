using Library_managment_Systems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_managment_Systems.Controllers
{
    public class AccountController : Controller
    {
        private libarayDb db = new libarayDb();
     public  AccountController()
        {
            db = new libarayDb();
        }

     protected override void Dispose(bool disposing)
     {
         db.Dispose();
     }
        public void x()
     {

     }

        //
        // GET: /Account/
        public ActionResult Index()
        {
            
            return View();
        }
	}
}