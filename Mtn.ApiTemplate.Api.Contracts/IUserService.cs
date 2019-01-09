using Mtn.ApiTemplate.Domain;

namespace Mtn.ApiTemplate.Api.Contracts
{
    public interface IUserService
    {
         User GetUser(int UserId);
    }
}