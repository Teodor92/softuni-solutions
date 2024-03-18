using EFCoreArchitecture.Infrastructure.Data.Common;
using Eventmi.Infrastructure.Data.Contexts;

namespace Eventmi.Infrastructure.Data.Repositories
{
    public class EventmiRepository : Repository, IEventmiRepository
    {
        public EventmiRepository(EventmiContext context)
            : base(context)
        {
        }
    }
}