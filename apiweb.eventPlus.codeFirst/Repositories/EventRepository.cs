using apiweb.eventPlus.codeFirst.Contexts;
using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;

namespace apiweb.eventPlus.codeFirst.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly EventContext _context;

        public EventRepository()
        {
            _context = new EventContext();
        }

        public void Create(Event newEvent)
        {
            _context.Events.Add(newEvent);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Event GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Event> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Event updatedEvent)
        {
            throw new NotImplementedException();
        }
    }
}
