using Eventmi.Core.Models.Event;

namespace Eventmi.Core.Contracts
{
    public interface IEventService
    {
        Task<IEnumerable<EventFormModel>> GetAllEventsAsync();

        Task<EventFormModel> GetEventAsync(int eventId);

        Task CreateEventAsync(EventFormModel model);

        Task EditEventAsync(EventFormModel model);

        Task DeleteEventAsync(int id);
    }
}
