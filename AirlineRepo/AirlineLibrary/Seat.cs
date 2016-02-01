using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    class Seat
    {
       
        string SeatNumber;
        int SeatPrice;
        public Seat(string seatNumber, int seatPrice)
        {
            SeatNumber = seatNumber;
            SeatPrice = seatPrice;
        }
    }
}
