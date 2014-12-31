using System;
using System.Web.Mvc;
using CEPM.Models;
using CEPMBL.Manager;

namespace CEPM.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            if (HttpContext != null)
            {
                if (HttpContext.Session != null) 
                    if (HttpContext.Session["User"] != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }
            }
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var manager = new UserManager();
                    var userName = model.UserName;
                    var password = model.Password;
                    ViewBag.UserName = userName;
                    var userId = manager.GetUserLoginId(userName, password);
                    if (!string.IsNullOrEmpty(userId))
                    {
                        if (HttpContext.Session != null) 
                            HttpContext.Session["User"] = userId;
                        return RedirectToAction("Index", "Home");
                    }
                    //return
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                    ModelState.AddModelError("", "User might not be active.");
                }

                // If we got this far, something failed, redisplay form
                return View(ModelState);
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
                return View(model);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult ForgotPassword(string recoverEmail)
        {
            try
            {
                var email = Request.QueryString["recoverEmail"];
                Console.WriteLine(email);
                return RedirectToAction("Login");
            }
            catch (Exception)
            {

                return View();
            }
            
        }
    }
}
