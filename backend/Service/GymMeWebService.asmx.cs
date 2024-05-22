using backend.Handler;
using backend.Model;
using backend.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace backend
{
    /// <summary>
    /// Summary description for GymMeWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GymMeWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void registerNewUser(String username,String email,String password,DateTime DOB,String gender,String role)
        {
            UserHandler.registerNewUser(username,email,password,DOB,gender,role); 
        }

        [WebMethod]
        public String login(String username,String password)
        {
            String result = UserHandler.login(username, password);
            return json<String>.encode(result);
        }

        [WebMethod]
        public String getUser(String username)
        {
            MsUser user = UserHandler.getUser(username);
            return json<MsUser>.encode(user);
        }

        [WebMethod]
        public String getSupplementList()
        {
            return json<List<MsSupplement>>.encode(SupplementHandler.getSupplement());
        }


    }
}
