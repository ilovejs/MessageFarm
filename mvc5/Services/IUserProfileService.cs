using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc5.Models;
using mvc5.ViewModel;

namespace mvc5.Services
{
    public interface IUserProfileService
    {
        UserProfile GetBy(int id);
        void Update(EditProfileViewModel model);
    }
}