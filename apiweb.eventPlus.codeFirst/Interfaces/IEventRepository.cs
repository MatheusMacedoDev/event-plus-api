using apiweb.eventPlus.codeFirst.Domains;

namespace apiweb.eventPlus.codeFirst.Interfaces
{
    public interface IEventRepository
    {
        void Create(Event newEvent);
        List<Event> ListAll();
        Event GetById(Guid id);
        void Update(Event updatedEvent);
        void Delete(Guid id);
    }
}
