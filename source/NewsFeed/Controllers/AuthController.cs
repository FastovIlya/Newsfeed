using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsFeed.Interfaces.Services;
using NewsFeed.Models.DTO;
using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json;
using System.Threading.Tasks;

namespace NewsFeed.Controllers
{
    [Route("v1/auth/")]
    public class AuthController : Controller
    {
        ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpPost("login")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success", type: typeof(FileContentResult))]
        //[SwaggerResponse(StatusCodes.Status404NotFound, "Items not found", type: typeof(Response))]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Service error", type: typeof(Response))]
        public async Task<IActionResult> LoginAsync([FromServices] IAuthService authService, [FromBody] AuthDto authDto)
        {
            var result = await authService.LoginUserAsync(authDto);
            return Ok(result);
        }

        [HttpPost("register")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success", type: typeof(FileContentResult))]
        //[SwaggerResponse(StatusCodes.Status404NotFound, "Items not found", type: typeof(Response))]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Service error", type: typeof(Response))]
        public async Task<IActionResult> RegisterAsync([FromServices] IAuthService authService, [FromBody] RegisterUserDto registerUserDto)
        {
            var result = await authService.RegisterUserAsync(registerUserDto);
            return Json(result);
        }
    }
}
