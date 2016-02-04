using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineLibrary;
using System.ComponentModel;

namespace Airline
{
    public class ItineraryView 
    {
        private Origin _originCity;

        public Origin _OriginCity
        {
            get { return _originCity; }
            set { _originCity = value; }
        }

        private Destination _destinationCity;

        public Destination _DestinationCity
        {
            get { return _destinationCity; }
            set { _destinationCity = value; }
        }
        private AirPlane _airplane;

        public AirPlane _AirPlane
        {
            get { return _airplane; }
            set { _airplane = value; }
        }
        private Passenger _passenger;

        public Passenger _Passenger
        {
            get { return _passenger; }
            set { _passenger = value; }
        }
        private Seat _seat;

        public Seat _Seat
        {
            get { return _seat; }
            set { _seat = value; }
        }
        public ItineraryView()
        {
            this._originCity = new Origin("Kanto");
        }


    }
}
