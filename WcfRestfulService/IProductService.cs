using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WcfRestfulService.Domain;

namespace WcfRestfulService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProjectService" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
   
        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Json,
             RequestFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "GetCommand/{command}")]
        List<Status> GetCommand(string command);
    }
}