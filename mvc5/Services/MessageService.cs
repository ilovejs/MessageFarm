using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using mvc5.Repositories;
using mvc5.Models;

namespace mvc5.Services
{
    public class MessageService : IMessageService
    {
        private readonly IContext _context;
        private readonly IMessageRepository _messages;

        public MessageService(IContext context)
        {
            _context = context;
            _messages = context.Messages;
        }

        public Message GetBy(int id)
        {
            return _messages.GetBy(id);
        }

        public Message Create(User user, string status, DateTime? created = null)
        {
            return Create(user.Id, status, created);
        }

        public IEnumerable<Message> GetReceivedMessages(int userId)
        {
            throw new NotImplementedException();
        }

        //overload
        public Message Create(int userId, string status, DateTime? created = null)
        {
           
            var message = new Message()
            {
                DateCreated = created.HasValue ? created.Value : DateTime.Now,
                Body = "",
                SenderId = 111,
                ReceiverId = 111
            };

            _messages.Create(message);
            //TODO: this is easy to miss, be careful
            _context.SaveChanges();
            return message;
        }

//        public IEnumerable<Message> GetTimelineFor(int userId)
//        {
//            //if user is ribbit's author's follower OR ribbit's author
//            return _ribbits.FindAll(r => r.Author.Followers.Any(f => f.Id == userId) || 
//                                         r.AuthorId == userId)
//                           .OrderByDescending(r => r.DateCreated);
//        }
    }
}