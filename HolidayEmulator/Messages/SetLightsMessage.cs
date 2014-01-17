using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HolidayEmulator.Messages
{
    public class SetLightsMessage
    {
        public SetLightsMessage(IEnumerable<Color> lightColours)
        {
            this.LightColours = lightColours;
        }

        public IEnumerable<Color> LightColours { get; private set; }
    }
}