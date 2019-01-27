using Microsoft.AspNetCore.Mvc;
using Mtn.ApiTemplate.Api.Contracts;
using Mtn.ApiTemplate.Services;
using Mtn.ApiTemplate.Models;

namespace Mtn.ApiTemplate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _user;

        public UsersController(IUserService user)
        {
            _user = user;
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return _user.GetUser(id);
        }
    }
}