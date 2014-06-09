using System.Collections.Generic;
using mvc5.Models;

namespace mvc5.Repositories
{
    public interface IMessageRepository: IRepository<Message>
    {
        Message GetBy(int id);
        IEnumerable<Message> GetFor(User user);
        void AddFor(Message ribbit, User user);
    }
}