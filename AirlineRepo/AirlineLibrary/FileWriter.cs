using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AirlineLibrary
{

    public class MyFileWriter
    {
        public Passenger p = new Passenger();
        public AirPlane a = new AirPlane(30,200,true,"Kanto to Johto");
        public Destination d = new Destination();
        public Origin o = new Origin("Kanto");
        public Seat s = new Seat(null,300,true);
        public SeatChart sc = new SeatChart();
        public Flight f = new Flight(null,101,null,null,null);
        public void WriteToFile(Passenger P, Origin O, Destination D)
        {
            this.p = P;
            this.o = O;
            this.d = D;
            
            TextWriter tw = new StreamWriter("PassengerManifest.csv", true);
            tw.Write(string.Format("Passenger:{0}\nOrigin:{1}\nDestination:{2}\n\n", P.Name , O.FlightOrigin,D.ChosenDestination));
            Console.WriteLine("Your Itinerary has been Created!");
            tw.Close();

        }
    }
}
