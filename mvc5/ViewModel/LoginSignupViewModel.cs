using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc5.ViewModel
{
    public class LoginSignupViewModel
    {
        public LoginViewModel Login { get; set; }
        public SignupViewModel Signup { get; set; }
    }
}