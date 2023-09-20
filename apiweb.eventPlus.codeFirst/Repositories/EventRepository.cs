﻿using apiweb.eventPlus.codeFirst.Contexts;
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
            Event findedEvent = GetById(id);

            if (findedEvent != null)
            {
                _context.Events.Remove(findedEvent);
                _context.SaveChanges();
            }
        }

        public Event GetById(Guid id)
        {
            return _context.Events.Select(e => new Event()
            {
                Id = e.Id,
                Name = e.Name,
                EventType = new EventType()
                {
                    TypeName = e.EventType!.TypeName
                },
                Institution = new Institution()
                {
                    FancyName = e.Institution.FancyName
                }

            }).FirstOrDefault()!;
        }

        public List<Event> ListAll()
        {
            return _context.Events.Select(e => new Event()
            {
                Id = e.Id,
                Name = e.Name,
                EventType = new EventType()
                {
                    TypeName = e.EventType!.TypeName
                },
                Institution = new Institution()
                {
                    FancyName = e.Institution.FancyName
                }

            }).ToList();
        }

        public void Update(Event updatedEvent)
        {
            throw new NotImplementedException();
        }
    }
}