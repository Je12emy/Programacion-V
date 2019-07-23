using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace myWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet Consulta_General()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=172.16.82.147;Initial Catalog=MusicStore;User ID=PrograMVC;Password=PrograMVC");
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Genre", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(ds);
            return ds;
        }
    }
}
