using System.ComponentModel;
using HostPanelPro.Web.Services;
using System.Linq;

namespace HostPanelPro.Server
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class Test
    {

        // a simple method echoing the message
        [WebMethod]
        public string Echo(string message)
        {
            return message;
        }

        // a method that receives a soap header. The soap header is written to the field settings of the base type HostingServiceProviderWebService.
        // In the client proxy, the soap header can be set by assign the header to  the SoapHeader property. The soap header is set in the client
        // in SoapHeaderMessageInspector in HostPanelPro.Web.Clients, and is read in the server by SoapHeaderMessageInspector in HostPanelPro.Web.Services

        [WebMethod]
        public void Touch() { }
    }
}
