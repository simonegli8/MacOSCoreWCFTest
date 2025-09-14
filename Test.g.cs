#if !Client
using System.ComponentModel;
using HostPanelPro.Web.Services;
using System.Linq;
using HostPanelPro.Server;
#if NETFRAMEWORK
using System.ServiceModel;
using System.ServiceModel.Web;
using SwaggerWcf.Attributes;
#else
using CoreWCF;
using CoreWCF.Web;
using CoreWCF.OpenApi.Attributes;
#endif

namespace HostPanelPro.Server.Services
{
    // wcf service contract
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("HostPanelPro.Build", "1.0")]
    [ServiceContract(Namespace = "http://tempuri.org/")]
#if NETFRAMEWORK
    [SwaggerWcf("/api/Test")]
#else
    [OpenApiBasePath("/api/Test")]
#endif
    public interface ITest
    {
        [WebMethod]
        [OperationContract]
        [WebGet(UriTemplate = "/Echo/{message}")]
        string Echo(string message);
        [WebMethod]
        [OperationContract]
        [WebGet(UriTemplate = "/Touch")]
        void Touch();
    }

    // wcf service
    [System.CodeDom.Compiler.GeneratedCodeAttribute("HostPanelPro.Build", "1.0")]
#if NETFRAMEWORK
    [System.ServiceModel.Activation.AspNetCompatibilityRequirements(RequirementsMode = System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode.Allowed)]
#endif
    public class Test : HostPanelPro.Server.Test, ITest
    {
        [WebMethod]
        public new string Echo(string message)
        {
            return base.Echo(message);
        }

        [WebMethod]
        public new void Touch()
        {
            base.Touch();
        }
    }
}
#endif