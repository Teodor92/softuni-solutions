using NUnit.Framework;
using Moq;
using Homies.Controllers;
using Homies.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Security.Principal;

namespace Homies.Tests
{
    [TestFixture]
    public class EventControllerTests
    {
        private Mock<IEventService> _mockEventService;
        private EventController _controller;

        [SetUp]
        public void Setup()
        {
            _mockEventService = new Mock<IEventService>();

            var user = new ClaimsPrincipal(new GenericPrincipal(new GenericIdentity("User"), null));
            _controller = new EventController(_mockEventService.Object)
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext { User = user }
                }
            };
        }

        [Test]
        public async Task Add_ReturnsViewResult()
        {
            //Call the action method being tested

            //Assert that the result is of the expected type

            //throw new NotImplementedException();
        }

        [Test]
        public async Task Join_UserNotJoined_ReturnsRedirectToActionResult()
        {
            // Step 1: Arrange - Set up the initial conditions for the test
            // Define the ID of the event to be used in the test
            int eventId = 1;

            // Set up the mock behavior for the event service:
            // Assume the user is not already joined to the event
            //_mockEventService.Setup(s => s.IsUserJoinedEventAsync(eventId, It.IsAny<string>())).ReturnsAsync(false);

            // Set up the mock behavior for joining the event:
            // Assume joining the event is successful
            //_mockEventService.Setup(s => s.JoinEventAsync(eventId, It.IsAny<string>())).ReturnsAsync(true);

            // Step 2: Act - Perform the action being tested
            // Call the controller method to join the event

            // Step 3: Assert - Verify the outcome of the action
            // Assert that the result returned is of the expected type

            // Convert the result to RedirectToActionResult for further assertions

            // Assert that the action name and controller name in the redirect result are as expected

            //throw new NotImplementedException();
        }


        [Test]
        public async Task Join_UserAlreadyJoined_ReturnsRedirectToActionResult()
        {
            // Step 1: Arrange - Set up the initial conditions for the test
            // Define the ID of the event to be used in the test
            int eventId = 1;

            // Set up the mock behavior for the event service:
            // Assume the user is already joined to the event

            // Step 2: Act - Perform the action being tested
            // Call the controller method to join the event

            // Step 3: Assert - Verify the outcome of the action
            // Assert that the result returned is of the expected type

            // Convert the result to RedirectToActionResult for further assertions

            // Assert that the action name and controller name in the redirect result are as expected
            //throw new NotImplementedException();
        }

    }
}
