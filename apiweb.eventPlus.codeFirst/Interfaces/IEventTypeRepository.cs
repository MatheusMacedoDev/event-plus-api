using apiweb.eventPlus.codeFirst.Domains;

namespace apiweb.eventPlus.codeFirst.Interfaces
{
    public interface IEventTypeRepository
    {
        void Create(EventType eventType);
        void Update(EventType newData);
        List<EventType> ListAll();
        EventType GetById(Guid id);
    }
}
