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
            EventComment findedEventComment = GetById(id);

            if (findedEventComment != null)
            {
                _context.EventComments.Remove(findedEventComment);
                _context.SaveChanges();
            }
        }

        public EventComment GetById(Guid id)
        {
            return _context.EventComments.FirstOrDefault(e => e.Id == id)!;
        }

        public List<EventComment> ListAll()
        {
            return _context.EventComments.ToList();
        }
    }
}
