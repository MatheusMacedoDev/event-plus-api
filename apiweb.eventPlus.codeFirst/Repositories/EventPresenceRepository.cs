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
            EventPresence findedEventPresence = _context.EventPresences.FirstOrDefault(e => e.Id == id);

            if (findedEventPresence != null)
            {
                _context.EventPresences.Remove(findedEventPresence);
                _context.SaveChanges();
            }
        }

        public List<EventPresence> ListByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public List<EventPresence> ListAll()
        {
            return _context.EventPresences.ToList();
        }

        public void Update(EventPresence updatedEventComment)
        {
            EventPresence findedEventPresence = _context.EventPresences.FirstOrDefault(e => e.Id == updatedEventComment.Id)!;

            if (findedEventPresence != null)
            {
                findedEventPresence.PresenceConfirmed = updatedEventComment.PresenceConfirmed;
                findedEventPresence.UserId = updatedEventComment.UserId;
                findedEventPresence.EventId = updatedEventComment.EventId;

                _context.EventPresences.Update(findedEventPresence);
                _context.SaveChanges();
            }
        }
    }
}
