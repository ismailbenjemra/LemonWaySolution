using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLemonWayWebserviceConsole.ServicesLemonWay;

namespace TestLemonWayWebserviceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceWebLemonWay service = new ServiceWebLemonWay()) 
            {

                Console.WriteLine("#########################Affichage de la sequence Fibonacci##############################");

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($" pour i ={i}" + "=====>" + service.GenerateFibonacciSequence(i).ToString("F0"));
                }

                Console.WriteLine("####################################Affichage du convertisseur de xml to json###########################");

                Console.WriteLine("display of the good xml ");

                string xml = @"<TRANS ><HPAY><ID> 103 </ID><STATUS> 3 </STATUS ><EXTRA><IS3DS> 0 </IS3DS><AUTH> 031183 </AUTH></EXTRA><INT_MSG/><MLABEL> 501767XXXXXX6700 </MLABEL><MTOKEN> project01 </MTOKEN></HPAY></TRANS> ";

                Console.WriteLine(service.Xml_To_Json(xml));

                string xmlbad = @"<foo>hello</bar>";

                Console.WriteLine("now the bad xml one ==============> " + xmlbad + " <======================");
                Console.WriteLine(service.Xml_To_Json(xmlbad));
                Console.ReadLine();
            }
        }
    }
}
