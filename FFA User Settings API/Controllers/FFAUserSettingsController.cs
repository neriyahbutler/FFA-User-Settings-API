using Application.Interface;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

// TODO -- Go through the swagger file we have for the API and ensure the summary and etc is accurate

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

        // User Settings Endpoints

        [HttpGet("/UserSettings/{username}")]
        [ProducesResponseType(200, Type = typeof(UserSettingsAPIModel))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetUserSettings(string username) 
            // NOTES FOR SELF:
            // An action result is the result of a controller action's execution in response to a browser request
            // One question I have though, why do we have to do "Task<IActionResult>" ?
            // I need to learn more about Task and ActionResult/IActionResult
        {
            var userSettings = await _ffaUserSettingsHandler.GetUserSettings(username);
            return Ok(userSettings);
        }

        [HttpPost("/UserSettings")]
        [ProducesResponseType(200, Type = typeof(UserSettingsAPIModel))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> InsertUserSettings(UserSettingsAPIModel? userSettingsInput)
        {
            var userSettings = await _ffaUserSettingsHandler.InsertUserSettings(userSettingsInput);
            return Ok(userSettings);
        }

        [HttpPatch("/UserSettings/{username}")]
        [ProducesResponseType(200, Type = typeof(UserSettingsAPIModel))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UpdateUserSettings(string username,  UserSettingsAPIModel? userSettingsInput)
        {
            var userSettings = await _ffaUserSettingsHandler.UpdateUserSettings(username, userSettingsInput);
            return Ok(userSettings);
        }
    }
}
