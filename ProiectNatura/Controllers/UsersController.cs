using Microsoft.AspNetCore.Mvc;
using ProiectNatura.Services;
using ProiectNatura.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProiectNatura.DTOs;
using ProiectNatura.Services.Interfaces;

namespace ProiectNatura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUser(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> CreateUser(UserDTO userDto)
        {
            var user = await _userService.AddUserAsync(userDto);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserDTO userDto)
        {
            if (id != userDto.Id)
            {
                return BadRequest();
            }

            await _userService.UpdateUserAsync(userDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _userService.DeleteUserAsync(id);
            return NoContent();
        }
    }
}
