using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using mvc5.Models;

namespace mvc5.Repositories
{
    public class UserProfileRepository : EfRepository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(DbContext context, bool sharedContext) 
            : base(context, sharedContext) { }
    }
}