using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IFFAUserSettingsHandler
    {
        public Task<UserSettingsAPIModel> GetUserSettings(string username);
        public Task<UserSettingsAPIModel> InsertUserSettings(UserSettingsAPIModel userSettings);
        public Task<UserSettingsAPIModel> UpdateUserSettings(string username, UserSettingsAPIModel userSettings);

        public Task<UserSettingsCharacterMovesAPIModel> GetCharacterMoves(string username, string characterName = "", string moveType = "");
        public Task<UserSettingsCharacterMovesAPIModel> InsertCharacterMoves(string username, string characterName);
        public Task<UserSettingsCharacterMovesAPIModel> UpdateCharacterMoves(string username, string characterName);
        public Task<UserSettingsCharacterMovesAPIModel> InitializeCharacterMovesSettings();
    }
}
