using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class Passenger
    {
        public string Name;
        public Seat ChosenSeat;
        public Passenger(string name, Seat chosenSeat)
        {
            Name = name;
            ChosenSeat = chosenSeat;
        }
        public Passenger()
        {
            string name;

        }
    }
}
