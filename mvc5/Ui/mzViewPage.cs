using mvc5.Repositories;
using mvc5.Repositories;
using mvc5.Models;
using mvc5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc5.Ui
{
    public abstract class mzViewPage : WebViewPage
    {
        protected IContext DataContext;
        public User CurrentUser { get; private set; }
        public IUserService Users { get; private set; }
        public ISecurityService Security { get; private set; }

        public mzViewPage()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();
        }
    }

    public abstract class mzViewPage<TModel> : WebViewPage<TModel>
    {
        protected IContext DataContext;
        public User CurrentUser { get; private set; }
        public IUserService Users { get; private set; }
        public ISecurityService Security { get; private set; }

        public mzViewPage()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();
        }
    }
}