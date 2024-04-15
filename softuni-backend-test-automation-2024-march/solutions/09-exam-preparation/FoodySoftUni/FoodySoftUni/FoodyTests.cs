using FoodySoftUni.Models;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Text.Json;

namespace FoodySoftUni
{
    public class FoodyTests
    {
        private RestClient client;
        private static string foodId;

        [OneTimeSetUp]
        public void Setup()
        {
            // Get Auth
            string accessToken = GetAccessToken("teodor92", "123456");

            var restOptions = new RestClientOptions("http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:86")
            {
                Authenticator = new JwtAuthenticator(accessToken),
            };

            this.client = new RestClient(restOptions);
        }

        private string GetAccessToken(string username, string password)
        {
            var authClient = new RestClient("http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:86");

            var authRequest = new RestRequest("/api/User/Authentication", Method.Post);
            authRequest.AddJsonBody(
            new AuthenticationRequest
            {
                UserName = username,
                Password = password
            });

            var response = authClient.Execute(authRequest);
            if (response.IsSuccessStatusCode)
            {
                var content = JsonSerializer.Deserialize<AuthenticationResponse>(response.Content);
                var accessToken = content.AccessToken;
                return accessToken;
            } 
            else
            {
                throw new InvalidOperationException("Authentication failed");   
            }
        }

        [Order(1)]
        [Test]
        public void CreateFood_WithRequiredFields_ShouldSucceed()
        {
            // Arrange
            var newFood = new FoodDto
            {
                Name = "New Test Food",
                Description = "Description",
                Url = "",
            };

            var request = new RestRequest("/api/Food/Create", Method.Post);
            request.AddJsonBody(newFood);

            // Act
            var response = this.client.Execute(request);

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));

            var data = JsonSerializer.Deserialize<ApiResponseDto>(response.Content);

            foodId = data.FoodId;
        }

        [Order(2)]
        [Test]
        public void EditFood_WithNewTitle_ShouldSucceed()
        {
            // Arrange
            var request = new RestRequest($"/api/Food/Edit/{foodId}", Method.Patch);

            request.AddJsonBody(new[]
            {
                new
                {
                    path = "/name",
                    op = "replace",
                    value = "New Food Title",
                },
            });

            // Act
            var response = this.client.Execute(request);

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var content = JsonSerializer.Deserialize<ApiResponseDto>(response.Content);

            Assert.That(content.Message, Is.EqualTo("Successfully edited"));
        }

        [Order(3)]
        [Test]
        public void GetAllFood_ShouldReturnAnArrayOfItems()
        {
            // Arrange
            var request = new RestRequest("/api/Food/All", Method.Get);

            // Act
            var response = this.client.Execute(request);

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var content = JsonSerializer.Deserialize<List<ApiResponseDto>>(response.Content);

            Assert.IsNotEmpty(content);
        }

        [Order(4)]
        [Test]
        public void DeleteFood_WithCorrectId_ShouldBeSuccesful()
        {
            // Arrange
            var request = new RestRequest($"/api/Food/Delete/{foodId}", Method.Delete);

            // Act
            var response = this.client.Execute(request);

            // Assert

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var content = JsonSerializer.Deserialize<ApiResponseDto>(response.Content);

            Assert.That(content.Message, Is.EqualTo("Deleted successfully!"));
        }

        [Order(5)]
        [Test]
        public void CreateFood_WithIncorrectData_ShouldFail()
        {
            // Arrange
            var request = new RestRequest("/api/Food/Create", Method.Post);
            request.AddJsonBody(new { });

            // Act
            var response = this.client.Execute(request);

            // Assert

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
        }

        [Order(6)]
        [Test]
        public void EditFood_WithNonExisitingId_ShouldFail()
        {
            // Arrange
            var request = new RestRequest($"/api/Food/Edit/XXXXXXXXXX", Method.Patch);

            request.AddJsonBody(new[]
            {
                new
                {
                    path = "/name",
                    op = "replace",
                    value = "New Food Title",
                },
            });

            // Act
            var response = this.client.Execute(request);

            // Assert

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));

            var content = JsonSerializer.Deserialize<ApiResponseDto>(response.Content);

            Assert.That(content.Message, Is.EqualTo("No food revues..."));
        }

        [Order(7)]
        [Test]
        public void DeleteFood_WithNonExistingId_ShouldFail()
        {
            // Arrange
            var request = new RestRequest("/api/Food/Delete/XASDAXAS", Method.Delete);

            // Act
            var response = this.client.Execute(request);

            // Assert

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));

            var content = JsonSerializer.Deserialize<ApiResponseDto>(response.Content);

            Assert.That(content.Message, Is.EqualTo("Unable to delete this food revue!"));
        }
    }
}