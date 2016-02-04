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


        public bool Available;
        public bool available
        {
            get { return Available; }
            set { Available = value; }
        }
        public Seat(string seatNumber, int seatPrice,bool available)
        {
            this.SeatNumber = seatNumber;
            this.SeatPrice = seatPrice;
            this.Available = available;
        }

        //public Seat()
        //{
        //    this.Available = true;
        //}
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
