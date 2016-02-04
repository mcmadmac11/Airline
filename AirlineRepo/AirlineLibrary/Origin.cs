using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class Origin
    {
        public string FlightOrigin;

        public string flightOrigin
        {
            get { return FlightOrigin; }
            set { FlightOrigin = value; }
        }
        public Origin(string flightOrigin)
        {
            FlightOrigin = flightOrigin;
        }
        //public Origin()
        //{

        //}
    }
}
