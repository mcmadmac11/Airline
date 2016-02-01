using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    class Passenger
    {
        string Name;
        Seat ChosenSeat;
        public Passenger(string name, Seat chosenSeat)
        {
            Name = name;
            chosenSeat = ChosenSeat;
        }
    }
}
