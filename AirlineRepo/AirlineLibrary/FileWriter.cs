using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace AirlineLibrary
{ 
    public class FileWriter
    {
        public string passengerName = "Dan McManus";
        XmlWriter writer = XmlWriter.Create("PassengerManifest.xml");
        public void WriteToXml()
        {
            //forech passenger in passengerList...
            writer.WriteStartDocument();

            writer.WriteElementString("Name", "Dan McManus");

            

        }
    }
}
