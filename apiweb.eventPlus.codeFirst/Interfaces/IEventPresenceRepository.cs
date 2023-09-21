using apiweb.eventPlus.codeFirst.Domains;

namespace apiweb.eventPlus.codeFirst.Interfaces
{
    public interface IEventPresenceRepository
    {
        void Create(EventPresence newEventComment);
        List<EventPresence> ListAll();
        List<EventPresence> ListByUserId(Guid userId);
        void Update(EventComment updatedEventComment);
        void Delete(Guid id);
    }
}
