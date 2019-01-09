using Mtn.ApiTemplate.Api.Contracts;
using Mtn.ApiTemplate.Domain;

namespace Mtn.ApiTemplate.Services
{
    public class UserService : IUserService
    {
        public User GetUser(int UserId)
        {
            // TODO: Make this do something
            return new User { UserId = -1, UserName = "TestName" };
        }
    }
}