using HolidayEmulator.EndPoint.Iotas;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HolidayEmulator.EndPoint
{
    [ServiceContract]
    public interface IHolidayEndPoint : IIotasEndPoint
    {
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/iotas/0.1/device/moorescloud.holiday/localhost/setlights", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        void SetLights(IEnumerable<string> lights);
    }
}
