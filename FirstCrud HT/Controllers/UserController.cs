using FirstCrudAPI_Hometask.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstCrud_HT.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers([FromQuery] int pageTooken, [FromQuery] int pageSize, [FromServices] UserService userService) 
        {
            var result = _userService.Get(user => true).Skip((pageTooken - 1) * pageSize).Take(pageSize).ToList();
            return result.Any() ? Ok(result) : NotFound();
        }
    }
}
