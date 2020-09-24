using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Query.XML.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = from student in XDocument.Load(@"C:\temp\data.xml").Descendants("Student")
                                         where (int)student.Element("TotalMarks") > 700
                                         orderby (int)student.Element("TotalMarks") descending
                                         select student.Element("Name").Value;

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine(); 
                                    
        }
    }
}
