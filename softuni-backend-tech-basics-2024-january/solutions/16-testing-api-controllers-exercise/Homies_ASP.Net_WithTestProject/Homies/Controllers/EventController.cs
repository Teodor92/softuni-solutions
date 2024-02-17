using Homies.Data;
using Homies.Data.Models;
using Homies.Models.Event;
using Homies.Models.Type;
using Homies.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Homies.Controllers
{
    [Authorize]
    public class EventController : Controller
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<IActionResult> Add()
        {
            EventFormModel eventModel = new EventFormModel()
            {
                Types = await GetTypes()
            };

            return View(eventModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EventFormModel eventModel)
        {
            var eventTypes = await GetTypes();

            if (!eventTypes.Any(e => e.Id == eventModel.TypeId))
            {
                ModelState.AddModelError(nameof(eventModel.TypeId), "Type does not exist!");
            }

            if (!ModelState.IsValid)
            {
                return View(eventModel);
            }

            string currentUserId = GetUserId();

            await _eventService.AddEventAsync(eventModel, currentUserId);

            return RedirectToAction("All", "Event");
        }

        public async Task<IActionResult> All()
        {
            var eventsToDisplay = await _eventService.GetAllEventsAsync();

            return View(eventsToDisplay);
        }

        public async Task<IActionResult> Join(int id)
        {

            string currentUserId = GetUserId();

            bool isAlreadyJoined = await _eventService.IsUserJoinedEventAsync(id, currentUserId);

            if (isAlreadyJoined)
            {
                return RedirectToAction("Joined", "Event");
            }

            bool result = await _eventService.JoinEventAsync(id, currentUserId);

            if (!result)
            {
                return BadRequest();
            }

            return RedirectToAction("Joined", "Event");
        }

        public async Task<IActionResult> Leave(int id)
        {
            var currentUser = GetUserId();

            bool result = await _eventService.LeaveEventAsync(id, currentUser);

            if (!result)
            {
                return BadRequest();
            }

            return RedirectToAction("All", "Event");
        }

        public async Task<IActionResult> Joined()
        {
            string currentUserId = GetUserId();

            var userEvents = await _eventService.GetUserJoinedEventsAsync(currentUserId);

            return View(userEvents);
        }

        public async Task<IActionResult> Details(int id)
        {
            var eventToDisplay = await _eventService.GetEventDetailsAsync(id);

            if (eventToDisplay == null)
            {
                return BadRequest();
            }

            return View(eventToDisplay);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var eventModel = await _eventService.GetEventForEditAsync(id);

            if (eventModel == null)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();
            string eventOrganiserId = await _eventService.GetEventOrganizerIdAsync(id);

            if (currentUserId != eventOrganiserId)
            {
                return Unauthorized();
            }

            return View(eventModel);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, EventFormModel model)
        {
            string currentUserId = GetUserId();
            string eventOrganiserId = await _eventService.GetEventOrganizerIdAsync(id);

            if (currentUserId != eventOrganiserId)
            {
                return Unauthorized();
            }

            bool result = await _eventService.UpdateEventAsync(id, model, currentUserId);

            if (result)
            {
                return RedirectToAction("All", "Event");
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<IEnumerable<TypeViewModel>> GetTypes()
        {
            var types = await _eventService.GetAllTypesAsync();
            return types.Select(t => new TypeViewModel
            {
                Id = t.Id,
                Name = t.Name
            });
        }

        private string GetUserId()
           => User.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
