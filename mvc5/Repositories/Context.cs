using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc5.Repositories
{
    //used in Controller
    public class Context: IContext
    {
        //EntitiesModel = dbcontext + UnitOfWork
        private readonly DbContext _db;

        public Context(IUserRepository people = null,
                       DbContext context = null,
                       IMessageRepository messages = null,
                       IUserProfileRepository profiles = null)
        {
            //inject different class
            _db = context ?? new MessageDatabase();
            Users = people ?? new UserRepository(_db);
            Messages = messages ?? new MessageRepository(_db);
            Profiles = profiles ?? new UserProfileRepository(_db, true);
        }

        public IUserRepository Users { get; private set; }
        public IMessageRepository Messages { get; private set; }
        public IUserProfileRepository Profiles { get; private set; }

        public void Dispose()
        {
            if (_db != null)
            {
                try
                {
                    _db.Dispose();
                }
                catch { }
            }
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}