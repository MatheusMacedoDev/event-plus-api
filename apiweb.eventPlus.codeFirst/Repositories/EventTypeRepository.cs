using apiweb.eventPlus.codeFirst.Contexts;
using apiweb.eventPlus.codeFirst.Domains;
using apiweb.eventPlus.codeFirst.Interfaces;

namespace apiweb.eventPlus.codeFirst.Repositories
{
    public class EventTypeRepository : IEventTypeRepository
    {
        private readonly EventContext _context;

        public EventTypeRepository()
        {
            _context = new EventContext();
        }

        public void Create(EventType eventType)
        {
            _context.EventTypes.Add(eventType);
            _context.SaveChanges();
        }

        public List<EventType> ListAll()
        {
            throw new NotImplementedException();
        }
        public EventType GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(EventType newData)
        {
            throw new NotImplementedException();
        }
    }
}
