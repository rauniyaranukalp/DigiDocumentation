using Domain.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace DigiDocumentation.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("add-user")]
        public async Task<IActionResult> AddUser(AddUserReq req)
        {
            var result = _userService.AddUser(req);
            return Ok(result);
        }
    }
}
