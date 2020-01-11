using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CreateXMLDoc
{
    class xmlDocument
    {
        public xmlDocument()
        {
            using(XmlWriter writer = XmlWriter.Create("document.xml"))
            {
                writer.WriteStartElement("document");
                writer.WriteElementString("title", "The XML document creation.");
                writer.WriteEndElement();
                writer.Flush();
            }
        }

    }
}
\repos\CreateXMLDoc