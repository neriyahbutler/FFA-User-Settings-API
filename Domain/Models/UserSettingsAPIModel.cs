using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserSettingsAPIModel
    {
        public string Username { get; set; }
        public IEnumerable<double> UserOverlayPosition { get; set; }
        public bool IsOverlayEnabled { get; set; }
        public bool IsGameMonitoringModeEnabled { get; set; }
        public int UserFontSize { get; set; }
    }
}
