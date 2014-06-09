using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using mvc5.Models;
using mvc5.ViewModel;

namespace mvc5.Services
{
    public interface ISecurityService
    {
        bool Authenticate(string username, string password);
        User CreateUser(SignupViewModel signupModel, bool login = true);
        bool DoesUserExist(string username);
        User GetCurrentUser();
        bool IsAuthenticated { get; }
        void Login(User user);
        void Login(string username);
        void Logout();
        //property can exist in interface
        int UserId { get; set; }
    }
}