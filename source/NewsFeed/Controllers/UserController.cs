using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsFeed.Interfaces.Services;
using NewsFeed.Services;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace NewsFeed.Controllers
{
    [Route("v1/")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger) 
        {
            _logger = logger;
        }

        [HttpGet("user")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success", type: typeof(FileContentResult))]
        //[SwaggerResponse(StatusCodes.Status404NotFound, "Items not found", type: typeof(Response))]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Service error", type: typeof(Response))]
        public async Task<IActionResult> GetAllUsers([FromServices] IUserService userService)
        {
            var result = await userService.GetAllUsersAsync();
            return Ok(result);
        }

        [HttpPut("user")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success", type: typeof(FileContentResult))]
        //[SwaggerResponse(StatusCodes.Status404NotFound, "Items not found", type: typeof(Response))]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Service error", type: typeof(Response))]
        public async Task<IActionResult> ReplaceUserData([FromServices] IUserService userService)
        {
            var result = await userService.ReplaceUserDataAsync();
            return Ok(result);
        }

        [HttpDelete("user")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success", type: typeof(FileContentResult))]
        //[SwaggerResponse(StatusCodes.Status404NotFound, "Items not found", type: typeof(Response))]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Service error", type: typeof(Response))]
        public async Task<IActionResult> DeleteUser([FromServices] IUserService userService)
        {
            var result = await userService.DeleteUserAsync();
            return Ok(result);
        }

        [HttpGet("user/{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success", type: typeof(FileContentResult))]
        //[SwaggerResponse(StatusCodes.Status404NotFound, "Items not found", type: typeof(Response))]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Service error", type: typeof(Response))]
        public async Task<IActionResult> GetUserInfoById([FromServices] IUserService userService)
        {
            var result = await userService.GetUserInfoByIdAsync();
            return Ok(result);
        }

        [HttpGet("user/info")]
        [SwaggerResponse(StatusCodes.Status200OK, "Success", type: typeof(FileContentResult))]
        //[SwaggerResponse(StatusCodes.Status404NotFound, "Items not found", type: typeof(Response))]
        //[SwaggerResponse(StatusCodes.Status500InternalServerError, "Internal Service error", type: typeof(Response))]
        public async Task<IActionResult> GetUserInfo([FromServices] IUserService userService)
        {
            var result = await userService.GetUserInfoAsync();
            return Ok(result);
        }
    }
}
