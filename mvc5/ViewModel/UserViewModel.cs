using mvc5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc5.ViewModel
{
    public class UserViewModel
    {
        public User User { get; set; }
        public IEnumerable<Message> Messages { get; set; }
    }
}