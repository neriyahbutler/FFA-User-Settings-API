using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserSettingsCharacterMovesAPIModel
    {
        public string Username { get; set; }
        public IEnumerator<CharacterMoves> CharactersMoves { get; set; }
    }

    public class CharacterMoves
    {
        public string CharacterName { get; set; }
        public Dictionary<string, string> CharacterFocusedMoves { get; set; }
    }
}
