using apiweb.eventPlus.codeFirst.Contexts;
using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;

namespace apiweb.eventPlus.codeFirst.Repositories
{
    public class EventPresenceRepository : IEventPresenceRepository
    {
        private readonly EventContext _context;

        public EventPresenceRepository()
        {
            _context = new EventContext();
        }

        public void Create(EventPresence newEventComment)
        {
            _context.EventPresences.Add(newEventComment);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<EventPresence> ListByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public List<EventPresence> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(EventComment updatedEventComment)
        {
            throw new NotImplementedException();
        }
    }
}
