using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.API.DTO;
using Project.Common;
using Project.Entity.Entity;
using System.Threading.Tasks;

namespace Project.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    return Unauthorized();
                }

                var result = await _userManager.CheckPasswordAsync(user, model.Password);
                if (!result)
                {

                    return Unauthorized();
                }


                var token = JwtProvider.GenerateJwtToken(user);

                return Ok(token);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
