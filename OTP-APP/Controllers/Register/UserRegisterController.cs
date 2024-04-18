using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OTP_APP.Domain;
//using OTP_APP.Domain;
using OTP_APP.Service;
using OTP_APP.Validations;

namespace OTP_APP.Controllers.Register
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRegisterController : Controller
    {
        private readonly IUserRegisterService _userRegisterService;

        public UserRegisterController(IUserRegisterService userRegisterService)
        {
            _userRegisterService = userRegisterService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterUser userRegister)
        {
            if (!UserRegisterValidation.IsValidEmail(userRegister.Email))
            {
                return BadRequest("Invalid");
            }

            if (!UserRegisterValidation.IsValidUsername(userRegister.Username))
            {
                return BadRequest("Invalid");
            }

            await _userRegisterService.AddUserAsync(userRegister);
            return Ok();
        }

        [HttpGet("GetUserByEmail/{email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var user = await _userRegisterService.GetUserByEmailAsync(email);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
       
    }
}
