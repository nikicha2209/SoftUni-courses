using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace ProductShop.Utilities
{
    public static class XmlHelper
    {
        
        public static IEnumerable<T> DeserializeCollection<T>(string inputXml, string rootElement)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T[]),
                new XmlRootAttribute(rootElement));

            T[] dtos;

            using (StringReader sr = new StringReader(inputXml))
            {
                dtos = (T[])xmlSerializer.Deserialize(sr);
            }

            return dtos;
        }


        public static string SerializeCollection<T>(T[] obj, string rootElement)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T[]),
                new XmlRootAttribute(rootElement));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);


            using (StringWriter writer = new StringWriter(sb))
            {
                xmlSerializer.Serialize(writer, obj, namespaces);
            }

            return sb.ToString().TrimEnd();
        }

        public static string SerializeCollection<T>(T obj, string rootElement)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), new XmlRootAttribute(rootElement));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);


            using (StringWriter writer = new StringWriter(sb))
            {
                xmlSerializer.Serialize(writer, obj, namespaces);
            }

            return sb.ToString().TrimEnd();
        }

    }
}
