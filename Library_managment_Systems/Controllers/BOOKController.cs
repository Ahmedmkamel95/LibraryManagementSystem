using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LMS_Core.Business;
using LMS_model;
using System.Net;

namespace Library_managment_Systems.Controllers
{
    public class BOOKController : Controller
    {
        public BookBL BookBl = new BookBL();

        // GET: /BOOK/
        public ActionResult Index()
        {
            var model = BookBl.GetAllbook();
            return View(model);
        }
        public ActionResult Details(int? id )
        {
            var model = BookBl.GetDetails(id);
            return View(model);
        }
        //Get 
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="id,title,SBIN,NumberOfCopied,describtion")] Book book)
        {
             if (ModelState.IsValid)
             {
                 BookBl.CreateBook(book);
             }
             return RedirectToAction("Index", "BOOK");

        }
        //Get
        public ActionResult Edit(int? id)
        {
            var m = BookBl.CheckFind(id);
            if (m == null)
            {
                return HttpNotFound();

            }
            else
                return View(m);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit ([Bind(Include="id,title,SBIN,NumberOfCopied,describtion")] Book book)
        {
            if (ModelState.IsValid)
                BookBl.EditBookData(book);
            return RedirectToAction("Index", "BOOK");
        }
        public ActionResult Delete (int ?id)
        {
            var m = BookBl.CheckFind(id);
            if (id == null)
                return HttpNotFound();
            else
                return View(m);
        }
    [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmedDelete(int? id)
        {
          
                BookBl.Delete(id);
                return RedirectToAction("Index", "BOOK");
            
        }
        public ActionResult Search(string title)
    {
       var m= BookBl.Search(title);
        return View("Search",m);
    }
	}
}