using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Flight
    {
        AirPlane airPlane;
        int FlightNumber;
        Origin origin;
        Destination destination;
        List<Passenger> PassengerManifest;
        public Flight(AirPlane airPlane, int flightNumber, Origin origin, Destination destination, List<Passenger>passengerManifest)
        {
            this.airPlane = airPlane;
            this.FlightNumber = flightNumber;
            this.origin = origin;
            this.destination = destination;
            this.PassengerManifest = passengerManifest;
        }
    }
}
