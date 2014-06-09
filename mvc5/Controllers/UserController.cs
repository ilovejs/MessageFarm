using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using mvc5.ViewModels;
using ControllerBase = mvc5.Controllers.ControllerBase;

namespace mvc5.Controllers
{
    public class UserController: ControllerBase
    {
  
        // GET: User
        public ActionResult Index()
        {
            return RedirectToAction("Register");
        }

        [HttpGet]
        public ActionResult Register()
        {
            //show form
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterVM model)
        {

            return View();
        }

        protected override void ExecuteCore()
        {
            throw new NotImplementedException();
        }
    }
}