﻿using apiweb.eventPlus.codeFirst.Domains;

namespace apiweb.eventPlus.codeFirst.Interfaces
{
    public interface IEventCommentRepository
    {
        void Create(EventComment eventComment);
        List<EventComment> ListAll();
        List<EventComment> ListByEvent(Guid eventId);
        EventComment GetById(Guid id);
        void Delete(Guid id);
    }
}
