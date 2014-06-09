
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc5.Models;

namespace mvc.ViewModel
{
    public class BuddiesViewModel
    {
        public User User { get; set; }
        public IEnumerable<User> Buddies { get; set; }
    }
}