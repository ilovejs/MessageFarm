using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc5.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string WebsiteUrl { get; set; }
        public string Bio { get; set; }
        public int Gendar { get; set; }
        public string Suburb { get; set; }
        public string Photo { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}