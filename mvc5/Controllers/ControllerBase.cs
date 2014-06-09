using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc5.Models;
using mvc5.Repositories;
using mvc5.Services;

namespace mvc5.Controllers
{
    public class ControllerBase: Controller
    {
        protected IContext DataContext;
        public User CurrentUser { get; private set; }
        public IMessageService Messages { get; private set; }
        public IUserService Users { get; private set; }
        public ISecurityService Security { get; private set; }
        public IUserProfileService Profiles { get; private set; }

        public ControllerBase()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Messages = new MessageService(DataContext);
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();
            Profiles = new UserProfileService(DataContext);
        }

        protected override void Dispose(bool disposing)
        {
            if (DataContext != null)
            {
                DataContext.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult GoToReferrer()
        {
            if (Request.UrlReferrer != null)
            {
                return Redirect(Request.UrlReferrer.AbsoluteUri);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}