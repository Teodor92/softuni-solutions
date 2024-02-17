namespace Homies.Models.Event
{
    public class EventViewDetailsModel : EventViewShortModel
    {
        public string End { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string CreatedOn { get; set; } = null!;
    }
}
