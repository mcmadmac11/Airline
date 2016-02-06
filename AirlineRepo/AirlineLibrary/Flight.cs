using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class Flight
    {
        SeatChart chart = new SeatChart();


        public AirPlane airPlane;

        public AirPlane _airPlane
        {
            get { return airPlane; }
            set { airPlane = value; }
        }

        public int FlightNumber;

        public int flightNumber
        {
            get { return FlightNumber; }
            set { FlightNumber = value; }
        }

        public Origin origin;

        public Origin _Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public Destination destination;

        public Destination Destination
        {
            get { return Destination; }
            set { destination = value; }
        }

        public List<Passenger> PassengerManifest;

        public List<Passenger> passengerManifest
        {
            get { return PassengerManifest; }
            set { PassengerManifest = value; }
        }
        public Flight(AirPlane airPlane, int flightNumber, Origin origin, Destination destination, List<Passenger> passengerManifest)
        {
            this.airPlane = airPlane;
            this.FlightNumber = flightNumber;
            this.origin = origin;
            this.destination = destination;
            this.PassengerManifest = passengerManifest;
        }






    }
}

