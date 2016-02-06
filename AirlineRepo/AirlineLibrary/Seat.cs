using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class Seat
    {
       
        public string SeatNumber;
        public string seatNumber
        {
            get { return SeatNumber; }
            set { SeatNumber = value; }
        }

        public int SeatPrice;
        public int seatPrice
        {
            get { return SeatPrice; }
            set { SeatPrice = value; }
        }


        public bool isAvailable;
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }
        public Seat(string seatNumber, int seatPrice,bool isAvailable)
        {
            this.SeatNumber = seatNumber;
            this.SeatPrice = seatPrice;
            this.isAvailable = isAvailable;
        }

        public Seat()
        {
            this.isAvailable = true;
        }
        public string getSeatValue()
        {
            return this.SeatPrice.ToString();
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
            return isAvailable;
            
        }
        public bool makeUnAvailable()
        {
            return this.isAvailable = false;
        }

        
    }
}
