using apiweb.eventPlus.codeFirst.Domains;

namespace apiweb.eventPlus.codeFirst.Interfaces
{
    public interface IEventPresenceRepository
    {
        void Create(EventPresence newEventComment);
        List<EventPresence> ListAll();
        List<EventPresence> ListByUserId(Guid userId);
        void Update(EventPresence updatedEventComment);
        void Delete(Guid id);
    }
}
