using Xunit;
using Moq;
using AutoFixture;
using Mtn.ApiTemplate.Api.Contracts;
using Mtn.ApiTemplate.Services;

namespace Mtn.ApiTemplate.Services.Tests.UserServiceFacts
{
    public class GetUserFacts
    {
        private readonly IFixture _fixture;
        private readonly IUserService _service;

        public GetUserFacts()
        {
            _fixture = new Fixture();
            
            _service = new UserService();
        }

        [Fact]
        public void GetUserReturnsTestUser()
        {
            // Arrange
            var userId = _fixture.Create<int>();

            // Act
            var result = _service.GetUser(userId);

            // Assert
            Assert.Equal(-1, result.UserId);
        }
    }
}