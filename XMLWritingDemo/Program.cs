using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLWritingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriter xmlWriter = XmlWriter.Create("C:\\temp\\test.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("users");

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "42");
            xmlWriter.WriteString("John Doe");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "39");
            xmlWriter.WriteString("Jane Doe");

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();

            Console.WriteLine("Done!");
            Console.ReadLine();

        }
    }
}
