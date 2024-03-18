using Eventmi.Core.Contracts;
using Eventmi.Core.Models.Event;
using Microsoft.AspNetCore.Mvc;

namespace Eventmi.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _service;

        public EventController(IEventService service)
        {
            _service = service;
        }

        public async Task<IActionResult> All()
        {
            return View(await _service.GetAllEventsAsync());
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(EventFormModel model)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateEventAsync(model);
                return RedirectToAction(nameof(All));
            }
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var eventForDetails = await _service.GetEventAsync(id);

            if (eventForDetails == null)
            {
                return NotFound();
            }

            return View(eventForDetails);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventToEdit = await _service.GetEventAsync(id ?? 0);


            if (eventToEdit == null)
            {
                return NotFound();
            }

            return View(eventToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EventFormModel eventModel)
        {
            if(id != eventModel.Id)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                try
                {
                    await _service.EditEventAsync(eventModel);
                }
                catch (ArgumentException ae)
                {
                    return NotFound();
                }

                return RedirectToAction("All", "Event");
            }
            return View(eventModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || id == 0) 
            {
                return NotFound();
            }

            var eventToDelete = await _service.GetEventAsync(id);

            if (eventToDelete == null)
            {
                return NotFound();
            }

            try
            {
                await _service.DeleteEventAsync(id);
            }
            catch (ArgumentException ae)
            {
                return NotFound();
            }


            return RedirectToAction(nameof(All));
        }
    }
}