using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;

namespace LeagueOfLegends_Selector
{
    class Program
    {
        static void Main(string[] args)
        {

            //Please Put LeagueofLegendsxml.xml in the bin folder with the project.
            XmlTextReader reader = new XmlTextReader("LeagueofLegendsxml.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
                Console.ReadLine();
            }

            
        }
    }
}
