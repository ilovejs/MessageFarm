using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using mvc5.Models;

namespace mvc5.Repositories
{
    public class UserRepository: EfRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) 
            : base(context)
        {
        }

        public IQueryable<User> All(bool includeProfile)
        {
            return includeProfile ? DbSet.Include(u => u.Profile).AsQueryable() : All();
        }

        public void CreateFollower(string username, User follower)
        {
            var user = GetBy(username);
            DbSet.Attach(follower);

            //user.Followers.Add(follower);

            if (!ShareContext)
            {
                Context.SaveChanges();
            }
        }

        public void DeleteFollower(string username, User follower)
        {
            var user = GetBy(username);
            DbSet.Attach(follower);

            //user.Followers.Remove(follower);

            if (!ShareContext)
            {
                Context.SaveChanges();
            }
        }

        public User GetBy(int id, 
                          bool includeProfile = false, 
                          bool includeRibbits = false,
                          bool includeFollowers = false, 
                          bool includeFollowing = false)
        {
            var query = BuildUserQuery(includeProfile, includeRibbits, includeFollowers, includeFollowing);

            return query.SingleOrDefault(u => u.Id == id);
        }

        private IQueryable<User> BuildUserQuery(bool includeProfile, bool includeRibbits, bool includeFollowers, bool includeFollowing)
        {
            var query = DbSet.AsQueryable();

//            if (includeProfile)
//                query = DbSet.Include(u => u.Profile);

//            if (includeRibbits)
//                query = DbSet.Include(u => u.);
//
//            if (includeFollowers)
//                query = DbSet.Include(u => u.Followers);
//
//            if (includeFollowing)
//                query = DbSet.Include(u => u.Followings);
            return query;
        }

        public User GetBy(string username, bool includeProfile = false, bool includeRibbits = false,
            bool includeFollowers = false, bool includeFollowing = false)
        {
            var query = BuildUserQuery(includeProfile, includeRibbits, includeFollowers, includeFollowing);

            return query.SingleOrDefault(u => u.Username == username);

        }
    }
}