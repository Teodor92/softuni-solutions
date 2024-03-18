using EFCoreArchitecture.Infrastructure.Data.Common;
using Eventmi.Core.Contracts;
using Eventmi.Core.Models.Event;
using Eventmi.Infrastructure.Data.Repositories;
using Eventmi.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Eventmi.Core.Services
{
    public class EventService : IEventService
    {
        private readonly IEventmiRepository _repo;

        public EventService(IEventmiRepository repo)
        {
            _repo = repo;
        }

        public async Task CreateEventAsync(EventFormModel model)
        {
            if (model.Start > model.End)
            {
                throw new ArgumentException("Invalid Event Start/End!");
            }
            var newEvent = new Event()
            {
                Name = model.Name,
                Start = model.Start,
                End = model.End,
                Place = model.Place
            };

            await _repo.AddAsync(newEvent);
            await _repo.SaveChangesAsync();
        }

        public async Task DeleteEventAsync(int eventId)
        {
            var eventToDelete = await _repo.GetByIdAsync<Event>(eventId);
            if(eventToDelete == null || eventId == 0)
            { 
                throw new ArgumentException("Invalid Event Id!");
            }
            _repo.Delete<Event>(eventToDelete);
            await _repo.SaveChangesAsync();
        }

        public async Task EditEventAsync(EventFormModel model)
        {
            var eventToEdit = await _repo.GetByIdAsync<Event>(model.Id);
            if (eventToEdit == null)
            {
                throw new ArgumentException("Invalid Event Id!");
            }
            eventToEdit.Name = model.Name;
            eventToEdit.Start = model.Start;
            eventToEdit.End = model.End;
            eventToEdit.Place = model.Place;

            await _repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<EventFormModel>> GetAllEventsAsync()
        {
            return await _repo.AllReadonly<Event>()
                .Select(e => new EventFormModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start,
                    End = e.End,
                    Place = e.Place
                })
                .ToListAsync();
        }

        public async Task<EventFormModel> GetEventAsync(int eventId)
        {
            var eventToDisplay = await _repo.GetByIdAsync<Event>(eventId);
            if(eventToDisplay == null)
            {
                throw new ArgumentException("Invalid Event Id!");
            }

            return new EventFormModel()
            {
                Id = eventToDisplay.Id,
                Name = eventToDisplay.Name,
                Start = eventToDisplay.Start,
                End = eventToDisplay.End,
                Place = eventToDisplay.Place
            };
        }

    }
}