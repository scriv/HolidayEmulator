using HolidayEmulator.EndPoint.Iotas;
using HolidayEmulator.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Windows.Media;

namespace HolidayEmulator.EndPoint
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, UseSynchronizationContext = false)]
    public class HolidayEndPoint : IHolidayEndPoint
    {
        public void SetLights(IEnumerable<string> lights)
        {
            App.EventAggregator.Publish(new SetLightsMessage(lights.Select(hex => (Color)ColorConverter.ConvertFromString(hex)).ToArray()));
        }

        public Device Discover()
        {
            return new Device();
        }
    }
}