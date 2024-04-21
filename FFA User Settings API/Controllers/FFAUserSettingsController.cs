using Application.Interface;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace FFA_User_Settings_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // A class that handles the incoming HTTP requests and responds back to the consumer
    public class FFAUserSettingsController : Controller
    {
        private readonly IFFAUserSettingsHandler _ffaUserSettingsHandler;

        public FFAUserSettingsController(IFFAUserSettingsHandler ffaUserSettingsHandler)
        {
            _ffaUserSettingsHandler = ffaUserSettingsHandler;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<UserSettingsAPIModel>))]
    }
}
