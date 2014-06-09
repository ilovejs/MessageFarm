using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using mvc5.Models;


namespace mvc5.Repositories
{
    public class MessageRepository : EfRepository<Message>, IMessageRepository
    {
        public MessageRepository(DbContext context)
            : base(context) { }

        public Message GetBy(int id)
        {
            return Find(r => r.Id == id);
        }

        public IEnumerable<Message> GetFor(User user)
        {
            //
            return user.SentMessages.OrderByDescending(r => r.DateCreated);
        }

        public void AddFor(Message ribbit, User user)
        {
            //
            user.SentMessages.Add(ribbit);

            if (!ShareContext)
            {
                Context.SaveChanges();
            }
        }
    }
}