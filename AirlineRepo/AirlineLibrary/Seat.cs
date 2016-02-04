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
        bool Available;
        public Seat(string seatNumber, int seatPrice,bool available)
        {
            this.SeatNumber = seatNumber;
            this.SeatPrice = seatPrice;
            this.Available = available;
        }
        public bool isAvailable;
        public Seat()
        {
            this.isAvailable = true;
        }

        public string getSeatName()
        {
                return this.SeatNumber;
        }

        public string setSeatNameNull()
        {
            return this.SeatNumber = null;
        }

        public bool checkAvailability()
        {
            if (true)
            {
                return true;
            }
        }
        public bool makeUnAvailable()
        {
            return this.Available = false;
        }

        
    }
}
