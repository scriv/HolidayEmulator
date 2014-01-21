using System.ServiceModel;
using System.ServiceModel.Web;

namespace HolidayEmulator.EndPoint.Iotas
{
    [ServiceContract]
    public interface IIotasEndPoint
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/iotas/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Device Discover();
    }
}