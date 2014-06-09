using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc5.Repositories
{
    public interface IContext: IDisposable
    {
        IUserRepository Users { get; }
        IUserProfileRepository Profiles { get; }
        IMessageRepository Messages { get; }
        void SaveChanges();
    }
}