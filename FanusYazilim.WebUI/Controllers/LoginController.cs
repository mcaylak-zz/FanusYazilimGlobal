using FanusYazilim.BusinessLayer.Concrete.Managers;
using FanusYazilim.Entities;
using FanusYazilim.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FanusYazilim.WebUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        private LoginManager _loginManager = new LoginManager();
        private CategoryManager _CategoryRepo = new CategoryManager();

        [HttpGet]
        #region Login
        public ActionResult Login()
        {
            _CategoryRepo.AllList();
            return View();
        }
        #endregion

        [HttpPost]
        #region Login
        public ActionResult Login(LoginViewModel model)
        {
            User user = new User();
            user.Email = model.Email.ToLower();
            user.Password = model.Password;

            if (_loginManager.LoginControl(user))
            {
                Session["User"] = model.Email;
                Session["Admin"] = 1;

                return RedirectToAction("Statistics", "Home");
            }
            else
            {
                ViewBag.ValidLogin = "E-mail Adresiniz Veya Parolanız Hatalıdır.";
                return View();
            }


        }

        #endregion




        [HttpGet]
        #region ForgotPassword

        public ActionResult ForgotPassword()
        {
            return View();
        }
        #endregion

        [HttpPost]
        #region ForgotPassword

        public ActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_loginManager.EmailExits(model.Email))
                    ViewBag.True = "E-mail Adresinize Gönderilen Linke Tıklayın.";
                else
                    ViewBag.False = "Girdiğiniz E-mail Adresi Sisteme Kayıtlı Değildir.";
            }

            return View();
        }
        #endregion




        [HttpGet]
        #region NewPassword

        public ActionResult NewPassword(string guid)
        {
            
            if (_loginManager.NewPassGuidControl(guid))
            {
                return View();
            }
            return RedirectToAction("Login");
        }

        #endregion

        [HttpPost]
        #region NewPassword

        public ActionResult NewPassword(NewPasswordViewModel model)
        {
            if (_loginManager.ChangeNewPassword(model.Password))
            {
                return RedirectToAction("Login");
            }
            return RedirectToAction("Login");
        }

        #endregion




        #region Logout
        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();

            return RedirectToAction("Login");
        }

        #endregion
    }
}