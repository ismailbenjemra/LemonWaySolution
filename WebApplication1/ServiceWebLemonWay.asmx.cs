using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace WebApplication1
{
    /// <summary>
    /// Description résumée de ServiceWebLemonWay
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceWebLemonWay : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World Marhaba";
        }

        [WebMethod]
        public double GenerateFibonacciSequence(int n)
        {
            double firstArg = 0;
            double secondArg = 1;

            Dictionary<int, double> mydict = new Dictionary<int, double>();

            if (1 <= n && n <= 100)
            {
                for (int i = 0; i < n; i++)
                {

                    double temp = firstArg;
                    firstArg = secondArg;
                    secondArg = temp + secondArg;
                }

                return firstArg;
            }
            else
            {
                return -1;
            }
        }

        [WebMethod]
        public string Xml_To_Json(string xml)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string json = JsonConvert.SerializeXmlNode(doc);
                return json;
            }
            catch (Exception ex)
            {
                return "Bad Xml format";
            }
        }
    }
}
