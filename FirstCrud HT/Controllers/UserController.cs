using FirstCrudAPI_Hometask.Models;
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

        [HttpGet("asd")]
        public IActionResult GetAllUsers([FromQuery] int pageTooken, int pageSize, [FromServices] UserService userService) 
        {
            var result = userService.Get(user => true).Skip((pageTooken - 1) * pageSize).Take(pageSize).ToList();
            return result.Any() ? Ok(result) : NotFound();
        }

        [HttpGet("{userId:guid}")]
        public async ValueTask<IActionResult> GetById([FromRoute] Guid userId)
        {
            var result = await _userService.GetByIdAsync(userId);
            return result is not null ? Ok(result) : NotFound(userId);
        }

        [HttpPost("user")]
        public async ValueTask<IActionResult> CreateUser(User user)
        {
            var result = await _userService.CreateAsync(user);
            return CreatedAtAction(nameof(GetById), new {userId = user.Id}, result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync([FromBody] User user)
        {
            await _userService.UpdateAsync(user);
            return NoContent();
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync([FromRoute] Guid userId)
        {
            await _userService.DeleteAsync(userId);
            return NoContent();
        }
    }
}
