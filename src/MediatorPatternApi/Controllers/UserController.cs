using MediatorPatternApi.CommandandQuery;
using MediatorPatternApi.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;  

namespace MediatorPatternApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IMediator _mediator;
        // Define the file path
        public static string filePath = "G:\\DotNetProject\\ApiWithMediator\\src\\MediatorPatternApi\\Data\\UserDetails.json";
        public UserController(ILogger<UserController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet(Name = "user")]
        public async Task<IActionResult> Get([FromQuery] GetUserRequest request)
        {
            //CallerMethod call = new CallerMethod();
            //GetUserResponse response = call.Calling(Id);
            var resonse  = await _mediator.Send(request);

            string existingJson = System.IO.File.ReadAllText(filePath);

            List<User> userList = JsonConvert.DeserializeObject<List<User>>(existingJson) ?? new List<User>();

            if(userList.Any())
            {
                if(userList.Any(item => item.UserId.Equals(request.UserId.ToString())))
                {
                    User user = userList.First(x => x.UserId.Equals(request.UserId.ToString()));
                    return Ok(user);
                }

            }



            return NotFound($"The user with {request.UserId} id not found!!");
        }

        [HttpPost(Name = "register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequest request )
        {
            var resonse = await _mediator.Send(request);

            return Ok(resonse);
        }
    }
}
