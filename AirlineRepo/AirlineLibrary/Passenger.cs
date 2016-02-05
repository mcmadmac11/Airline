using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class Passenger 
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Seat chosenSeat;

        public Seat ChosenSeat
        {
            get { return chosenSeat; }
            set { chosenSeat = value; }
        }

        public Passenger(string name, Seat chosenSeat)
        {
            this.Name = name;
            this.ChosenSeat = chosenSeat;
        }
        public Passenger()
        {
            string name;

        }

        public string getPassengerSeatName()
        {
            return this.ChosenSeat.getSeatName();
        }
        //public void BuySeat(Passenger currentPassenger, Seat chosenSeat)
        //{
        //    if(chosenSeat!=null)
        //    {
        //        currentPassenger.ChosenSeat = chosenSeat;
        //        chosenSeat = null;
        //    }
        //    else
        //    {
        //        Console.WriteLine("that seat is already pearchesd");
        //    }

        //}
    }
}
