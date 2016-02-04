using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace AirlineLibrary
{

    public class MyFileWriter
    {
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        //Seat s = new Seat("A", 100, false);
        //Passenger p = new Passenger();
        //AirPlane a = new AirPlane();
        //Destination d = new Destination("London");
        //Flight f = new Flight();
        //Origin o = new Origin("Cleveland");
        SeatChart seatChart = new SeatChart();
        public Itinerary itinerary;

        public void WriteToXml()
        {
            this.filePath = @"C:\users\Dan\Documents\FlightDatabase.xml";
            seatChart.SeedSeatChart(10);
            this.itinerary = new Itinerary();
            XmlSerializer xmlWriter = new XmlSerializer(seatChart.GetType());
            StreamWriter writer = new StreamWriter(filePath);
            xmlWriter.Serialize(writer, seatChart);
        }





        //public void WriteItinerary(Passenger P, Origin O, Destination D, Seat S)
        //{
        //    this.p = P;
        //    this.o = O;
        //    this.d = D;
        //}
        //XmlTextWriter writer = null;
        //public void DocPrep()
        //{

        //    writer = new XmlTextWriter("PassengerManifest.xml", null);
        //    writer.Formatting = Formatting.Indented;
        //    writer.WriteStartDocument();
        //    writer.WriteDocType("Manifest", null, null,null);
        //    String Typetext = "type='text/xsl' href='manifest.xsl'";
        //    writer.WriteProcessingInstruction("xml-stylesheet", Typetext);
        //    writer.WriteStartElement("manifest");
        //    writer.WriteElementString(" passengerName", p.Name.ToString());
        //    writer.WriteElementString(" passengerSeat", p.ChosenSeat.getSeatName() + " " );
        //    writer.WriteElementString(" flight","  12345  " + "  " );
        //    writer.WriteElementString(" flight", "123456789");
        //    writer.WriteElementString(" Origin", o.FlightOrigin);
        //    writer.WriteElementString(" Destination", d.ChosenDestination);
        //    writer.WriteEndElement();
        //    writer.WriteEndDocument();
        //    writer.Flush();
        //    writer.Close();


        //    TextWriter tw = new StreamWriter("PassengerManifest.csv", true);
        //    tw.Write(string.Format("Passenger:{0}\nOrigin:{1}\nDestination:{2}\n\n", P.Name, O.FlightOrigin, D.ChosenDestination));
        //    Console.WriteLine("Your Itinerary has been Created!");
        //    tw.Close();

        //}
        //public static void WriteManifest(string args)
        //{

        //    TextWriter tw = new StreamWriter("PassengerManifest.csv", true);
        //    tw.Write("");
        //    tw.Close();

        //}
    }
}
