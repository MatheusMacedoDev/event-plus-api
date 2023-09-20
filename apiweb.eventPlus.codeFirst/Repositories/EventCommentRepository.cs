using apiweb.eventPlus.codeFirst.Contexts;
using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;

namespace apiweb.eventPlus.codeFirst.Repositories
{
    public class EventCommentRepository : IEventCommentRepository
    {
        private readonly EventContext _context;

        public EventCommentRepository()
        {
            _context = new EventContext();
        }

        public void Create(EventComment eventComment)
        {
            _context.EventComments.Add(eventComment);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public EventComment GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<EventComment> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
