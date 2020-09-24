using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq;
using System.IO;


/*
Create XML document using Linq to XML

    Key:
    XDocument
    XDeclaration
    XComment
    XElement
    XAttribute

*/
namespace LinqtoXMLDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "y"),
                new XComment("Creating an XML tree using LINQ-to-XML"),
                new XElement("Students",
                    //new XElement("Student", new XAttribute("Id", 101),
                    //    new XElement("Name", "Mark"),
                    //    new XElement("Gender", "Male"),
                    //    new XElement("TotalMarks", "800")),
                    //new XElement("Student", new XAttribute("Id", 102),
                    //    new XElement("Name", "Rosy"),
                    //    new XElement("Gender", "Female"),
                    //    new XElement("TotalMarks", "900")),
                    //new XElement("Student", new XAttribute("Id", 103),
                    //    new XElement("Name", "Pam"),
                    //    new XElement("Gender", "Female"),
                    //    new XElement("TotalMarks", "850")),
                    //new XElement("Student", new XAttribute("Id", 104),
                    //    new XElement("Name", "John"),
                    //    new XElement("Gender", "Male"),
                    //    new XElement("TotalMarks", "950"))
                        from student in Student.GetAllStudents()
                        select new XElement("Student", new XAttribute("Id", student.Id),
                                new XElement("Name", student.Name),
                                new XElement("Gender", student.Gender),
                                new XElement("TotalMarks", student.TotalMarks))
                        ));

            // delete file if it already exist
            String filename = @"C:\temp\data.xml";

            if (File.Exists(filename))
            {
                Console.WriteLine("XML file already exists, delete it!");
                File.Delete(filename);
            }
               
            xmlDocument.Save(filename);

            Console.WriteLine("XML file created!");
            Console.ReadLine();
        
        }
        
    }
}
