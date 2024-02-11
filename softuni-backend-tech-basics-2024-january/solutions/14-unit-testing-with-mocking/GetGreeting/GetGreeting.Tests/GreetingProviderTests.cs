using GetGreeting;
using Moq;

namespace GetGreeting.Tests
{
    public class GeetingProvierTests
    {
        private GreetingProvider _greetingProvider;
        private Mock<ITimeProvider> _mockedTimeProvider;

        [SetUp]
        public void Setup()
        {
            _mockedTimeProvider = new Mock<ITimeProvider>();
            _greetingProvider = new GreetingProvider(_mockedTimeProvider.Object);
        }

        [Test]
        public void GetGreeting_ShouldRetrunAMorningMessage_WhenItIsMoring()
        {
            // Arrange
            _mockedTimeProvider.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, 9, 9, 9));

            // Act 
            var result = _greetingProvider.GetGreeting();

            // Assert
            Assert.That(result, Is.EqualTo("Good morning!"));
            _mockedTimeProvider.Verify(x => x.GetCurrentTime(), Times.Once);
        }

        [Test]
        public void GetGreeting_ShouldReturnAAfternoonMessage_WhenItIsAfterNoon()
        {
            // Arrange
            _mockedTimeProvider.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, 13, 13, 13));

            // Act
            var result = _greetingProvider.GetGreeting();

            // Assert
            Assert.That(result, Is.EqualTo("Good afternoon!"));
        }

        [Test]
        public void GetGreeting_ShouldReturnAEveningMessage_WhenItIsEvening()
        {
            // Arrange
            _mockedTimeProvider.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, 19, 19, 19));

            // Act
            var result = _greetingProvider.GetGreeting();

            // Assert
            Assert.That(result, Is.EqualTo("Good evening!"));
        }

        [Test]
        public void GetGreeting_ShouldReturnANightMessage_WhenItIsNight()
        {
            // Arrange
            _mockedTimeProvider.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, 4, 19, 19));

            // Act
            var result = _greetingProvider.GetGreeting();

            // Assert
            Assert.That(result, Is.EqualTo("Good night!"));
        }

        [TestCase("Good night!", 4)]
        [TestCase("Good night!", 3)]
        [TestCase("Good night!", 2)]
        [TestCase("Good night!", 1)]
        [TestCase("Good evening!", 19)]
        [TestCase("Good afternoon!", 13)]
        [TestCase("Good morning!", 11)]
        public void GetGreeting_ShouldReturnCorrectMessage_WhenTimeIsCorrect(string expectedMessage, int currentHour)
        {
            // Arrange
            _mockedTimeProvider.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, currentHour, 19, 19));

            // Act
            var result = _greetingProvider.GetGreeting();

            // Assert
            Assert.That(result, Is.EqualTo(expectedMessage));
        }
    }
}