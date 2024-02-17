using Homies.Models.Event;
using Homies.Models.Type;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homies.Services
{
    public interface IEventService
    {
        Task AddEventAsync(EventFormModel eventModel, string userId);
        Task<IEnumerable<EventViewShortModel>> GetAllEventsAsync();
        Task<EventViewDetailsModel> GetEventDetailsAsync(int eventId);
        Task<string> GetEventOrganizerIdAsync(int eventId);
        Task<bool> JoinEventAsync(int eventId, string userId);
        Task<bool> LeaveEventAsync(int eventId, string userId);
        Task<IEnumerable<EventViewShortModel>> GetUserJoinedEventsAsync(string userId);
        Task<EventFormModel> GetEventForEditAsync(int eventId);
        Task<bool> UpdateEventAsync(int eventId, EventFormModel eventModel, string userId);
        Task<IEnumerable<TypeViewModel>> GetAllTypesAsync();
        Task<bool> IsUserJoinedEventAsync(int id, string currentUserId);
    }
}
