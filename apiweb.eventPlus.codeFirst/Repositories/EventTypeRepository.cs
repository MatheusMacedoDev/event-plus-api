﻿using apiweb.eventPlus.codeFirst.Contexts;
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
            return _context.EventTypes.ToList();
        }
        public EventType GetById(Guid id)
        {
            return _context.EventTypes.FirstOrDefault(type => type.Id == id)!;
        }

        public void Update(EventType newData)
        {
            EventType findedEventType = GetById(newData.Id);

            if (findedEventType != null)
            {
                findedEventType.TypeName = newData.TypeName;

                _context.EventTypes.Update(findedEventType);
                _context.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            EventType findedEventType = GetById(id);

            if (findedEventType != null )
            {
                _context.EventTypes.Remove(findedEventType);
                _context.SaveChanges();
            }
        }
    }
}
