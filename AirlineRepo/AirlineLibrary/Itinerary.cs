using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class Itinerary<T>
    {
        public List<T> PassengerItinerary { get;  set; }
        public Origin OriginationCity { get; private set; }
        public Destination DestinationCity { get; private set; }
        public AirPlane Plane { get; private set; }
        public Passenger Traveler { get; private set; }
        public Seat AssignedSeat { get; private set; }

        public Itinerary(Origin origin, Destination destination,AirPlane airplane,Passenger passenger,Seat seat)
        {
            this.OriginationCity = origin;
            this.DestinationCity = destination;
            this.Plane = airplane;
            this.Traveler = passenger;
            this.AssignedSeat = seat;
            List<object> passengerItinerary = new List<object>();
            passengerItinerary.Add(Traveler);
            passengerItinerary.Add(AssignedSeat);
            passengerItinerary.Add(OriginationCity);
            passengerItinerary.Add(DestinationCity);
            passengerItinerary.Add(Plane);

        }
    }
}
