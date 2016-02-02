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
        Passenger p = new Passenger();
        AirPlane a = new AirPlane();
        Destination d = new Destination();
        Flight f = new Flight();
        Origin o = new Origin();
        Seat s = new Seat();
        SeatChart sc = new SeatChart();
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
