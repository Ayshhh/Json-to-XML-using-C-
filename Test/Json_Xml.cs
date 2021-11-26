using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Test
{
    class Json_Xml
    {
        static void Main(string[] args)
        {
            json_to_xml();
        }
        static void json_to_xml()
        {
            string data = File.ReadAllText(@"sample.json");
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(data);
            string str1 = JsonConvert.SerializeObject(obj[0]);
            string str2 = JsonConvert.SerializeObject(obj[1]);
            XmlDocument doc1 = JsonConvert.DeserializeXmlNode(str1, "root");
            XmlDocument doc2 = JsonConvert.DeserializeXmlNode(str2, "root");
            File.WriteAllTextAsync("Sample1.txt", doc1.InnerXml);
            File.WriteAllTextAsync("Sample2.txt", doc2.InnerXml);
        }
    }
}
