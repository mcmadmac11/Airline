using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class Itinerary
    {
        public Itinerary()
        {

        }
        //public List<T> passengerItinerary;
        //public List<T> PassengerItinerary
        //{
        //    get { return passengerItinerary; }
        //    set { passengerItinerary = value; }
        //}

        public string originationCity;
        public string OriginationCity
        {
            get { return originationCity; }
            set { originationCity = value; }
        }

        public string destinationCity;
        public string DestinationCity
        {
            get { return destinationCity; }
            set { destinationCity = value; }
        }

        public AirPlane plane;
        public AirPlane Plane
        {
            get { return plane; }
            set { plane = value; }
        }
        
        public Passenger traveler;
        public Passenger Traveler
        {
            get { return traveler; }
            set { traveler = value; }
        }

        public Seat assignedSeat;
        public Seat AssignedSeat
        {
            get { return assignedSeat; }
            set { assignedSeat = value; }
        }

        public Itinerary(string origin, string destination,AirPlane airplane,Passenger passenger,Seat seat)
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
