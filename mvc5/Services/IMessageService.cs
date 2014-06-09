using System;
using System.Collections.Generic;
using mvc5.Models;

namespace mvc5.Services
{
    public interface IMessageService
    {
        Message GetBy(int id);
        Message Create(int userId, string status, DateTime? created = null);
        Message Create(User user, string status, DateTime? created = null);
        IEnumerable<Message> GetReceivedMessages(int userId);
    }
}