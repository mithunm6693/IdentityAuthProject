using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserManager<User> _UserManager;

        public UserController(UserManager<User> UserManager)
        {
            _UserManager = UserManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterModel value)
        {
            User ObjUser = new User()
            {
                Firstname = value.FirstName,
                Lasttname = value.LasttName,
                Email = value.Email,
                UserName=value.Email,
           
            };

            var result = await _UserManager.CreateAsync(ObjUser, value.Password);

            if (result.Succeeded)
            {
                return Ok(200);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }


    }
}
