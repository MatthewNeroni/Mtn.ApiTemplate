using Mtn.ApiTemplate.Models;

namespace Mtn.ApiTemplate.Api.Contracts
{
    public interface IUserService
    {
         User GetUser(int UserId);
    }
}