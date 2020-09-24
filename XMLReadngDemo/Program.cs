using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

/*
using XmlDataDocument Class to read the XML file
*/

namespace XMLReadngDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream("C:\\Temp\\product.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs); //load the XML file to the XML doc object
            xmlnode = xmldoc.GetElementsByTagName("Product");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
