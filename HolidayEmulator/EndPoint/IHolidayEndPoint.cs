using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HolidayEmulator.EndPoint
{
    [ServiceContract]
    public interface IHolidayEndPoint
    {
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/iotas/0.1/device/moorescloud.holiday/localhost/setlights", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        void SetLights(IEnumerable<string> lights);
    }
}
