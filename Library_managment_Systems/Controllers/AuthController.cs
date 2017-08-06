using Library_managment_Systems.CustomLibraries;
using LMS_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Library_managment_Systems.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private LibarayDB _context;
        public AuthController()
        {
            _context = new LibarayDB();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = _context.Users.Single(u => u.Username == model.Username);
            var decryptedPassword = CustomDecrypt.Decrypt(user.password);

            if (model.Username != null && model.password == decryptedPassword)
            {
                //ClaimsIdentity contains information (Claims) about the current user
                var identity = new ClaimsIdentity("ApplicationCookie");

                //Request is an object that reads HTTP request values
                //GetOwinContext Gets the owin context that links the middleware to the request
                var ctx = Request.GetOwinContext();
                //Authentication property links the middleware to an authentication to the app
                var authManager = ctx.Authentication;
                //SignIn gets the list of claims and uses to authenticate those values to be persisted throughout the app
                //SignIn sets the authentication cookie on the client.
                authManager.SignIn(identity);

                //return Redirect(GetRedirect(model.ReturnUrl));
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Invalid email or password");
            return View(model);
        }

        private string GetRedirectUrl(string returnUrl)
        {
            //You have 2 options. Either to be redirected to the home page or the same model page if not authorized
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("index", "home");
            }
            return returnUrl;
        }

        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Login", "Auth");
        }

        public ActionResult Registeration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registeration(User user)
        {
            if (!ModelState.IsValid)
                return View(user);

            user.password = CustomEncrypt.Encrypt(user.password);
            _context.Users.Add(user);
            _context.SaveChanges();

            var identity = new ClaimsIdentity("ApplicationCookie");

            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;
            authManager.SignIn(identity);

            return RedirectToAction("Index", "Book");
        }
	}
}