using Homies.Data;
using Homies.Data.Models;
using Homies.Models.Event;
using Homies.Models.Type;
using Microsoft.EntityFrameworkCore;

namespace Homies.Services
{
    public class EventService : IEventService
    {
        private readonly HomiesDbContext _context;

        public EventService(HomiesDbContext context)
        {
            _context = context;
        }

        public async Task AddEventAsync(EventFormModel eventModel, string userId)
        {
            var eventToAdd = new Event
            {
                Name = eventModel.Name,
                Description = eventModel.Description,
                CreatedOn = DateTime.UtcNow, // Consider using UTC time
                TypeId = eventModel.TypeId,
                OrganiserId = userId,
                Start = eventModel.Start,
                End = eventModel.End
            };

            await _context.Events.AddAsync(eventToAdd);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<EventViewShortModel>> GetAllEventsAsync()
        {
            return await _context
                .Events
                .Select(e => new EventViewShortModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start.ToString("dd/MM/yyyy H:mm"),
                    //Type = e.Type.Name,
                    //Organiser = e.Organiser.UserName
                })
                .ToListAsync();
        }

        public async Task<EventViewDetailsModel> GetEventDetailsAsync(int eventId)
        {
            var eventDetails = await _context.Events
                .Where(e => e.Id == eventId)
                .Select(e => new EventViewDetailsModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start.ToString("dd/MM/yyyy H:mm"),
                    End = e.End.ToString("dd/MM/yyyy H:mm"),
                    //Organiser = e.Organiser.UserName,
                    //Type = e.Type.Name,
                    Description = e.Description,
                    CreatedOn = e.CreatedOn.ToString("dd/MM/yyyy H:mm")
                })
                .FirstOrDefaultAsync();

            return eventDetails;
        }

        public async Task<EventFormModel> GetEventForEditAsync(int eventId)
        {
            var eventToEdit = await _context.Events
                .Where(e => e.Id == eventId)
                .Select(e => new EventFormModel
                {
                    Name = e.Name,
                    Description = e.Description,
                    TypeId = e.TypeId,
                    Start = e.Start,
                    End = e.End,
                })
                .FirstOrDefaultAsync();

            if (eventToEdit != null)
            {
                eventToEdit.Types = await _context.Types
                    .Select(t => new TypeViewModel { Id = t.Id, Name = t.Name })
                    .ToListAsync();
            }

            return eventToEdit;
        }

        public async Task<string> GetEventOrganizerIdAsync(int eventId)
        {
            var eventIdToReturn = await _context.Events
               .Where(e => e.Id == eventId)
               .Select(e => e.OrganiserId)
               .FirstOrDefaultAsync();

            return eventIdToReturn;
        }

        public async Task<IEnumerable<EventViewShortModel>> GetUserJoinedEventsAsync(string userId)
        {
            return await _context.EventsParticipants
                .Where(ep => ep.HelperId == userId)
                .Select(ep => new EventViewShortModel
                {
                    Id = ep.Event.Id,
                    Name = ep.Event.Name,
                    Start = ep.Event.Start.ToString("dd/MM/yyyy H:mm"),
                    Type = ep.Event.Type.Name,
                    //Organiser = ep.Event.Organiser.UserName
                })
                .ToListAsync();
        }

        public async Task<bool> JoinEventAsync(int eventId, string userId)
        {
            var eventToAdd = await _context.Events.FindAsync(eventId);
            if (eventToAdd == null)
            {
                return false;
            }

            bool alreadyJoined = await _context.EventsParticipants
                .AnyAsync(ep => ep.EventId == eventId && ep.HelperId == userId);
            if (alreadyJoined)
            {
                return false;
            }

            var entry = new EventParticipant
            {
                EventId = eventId,
                HelperId = userId,
            };

            _context.EventsParticipants.Add(entry);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> LeaveEventAsync(int eventId, string userId)
        {
            var entry = await _context.EventsParticipants
                .FirstOrDefaultAsync(ep => ep.EventId == eventId && ep.HelperId == userId);

            if (entry == null)
            {
                return false;
            }

            _context.EventsParticipants.Remove(entry);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateEventAsync(int eventId, EventFormModel eventModel, string userId)
        {
            var eventToUpdate = await _context.Events.FindAsync(eventId);

            if (eventToUpdate == null || eventToUpdate.OrganiserId != userId)
            {
                return false;
            }

            eventToUpdate.Name = eventModel.Name;
            eventToUpdate.Description = eventModel.Description;
            eventToUpdate.Start = eventModel.Start;
            eventToUpdate.End = eventModel.End;
            eventToUpdate.TypeId = eventModel.TypeId;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<TypeViewModel>> GetAllTypesAsync()
        {
            var types = await _context.Types.ToListAsync();
            return types.Select(t => new TypeViewModel
            {
                Id = t.Id,
                Name = t.Name
            });
        }

        public async Task<bool> IsUserJoinedEventAsync(int id, string currentUserId)
        {
            var isJoined = await _context.EventsParticipants
                .AnyAsync(ep => ep.EventId == id && ep.HelperId == currentUserId);

            return isJoined;
        }
    }
}
