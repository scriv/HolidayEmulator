using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayEmulator.EndPoint.Iotas
{
    public class Device
    {
        [JsonProperty("apis")]
        public object[] Apis { get; set; }

        [JsonProperty("ip")]
        public string IpAddress { get; set; }

        [JsonProperty("local_device")]
        public string LocalDevice { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("host_name")]
        public string HostName { get; set; }

        [JsonProperty("local_name")]
        public string LocalName { get; set; }
    }
}