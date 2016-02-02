using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class Seat
    {
       
        string SeatNumber;
        int SeatPrice;
        public Seat(string seatNumber, int seatPrice)
        {
            SeatNumber = seatNumber;
            SeatPrice = seatPrice;
        }

        public Seat()
        {

        }

        public string getSeatName()
        {
            if (this.SeatNumber != null)
            {
                return this.SeatNumber;
            }
            else
                return "null";
        }

        public string setSeatName()
        {
            return this.SeatNumber = null;
        }

        
    }
}
