using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineLibrary;
using System.ComponentModel;

namespace Airline
{
    public class PassengerView 
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Seat chosenSeat;

        public Seat ChosenSeat
        {
            get { return chosenSeat; }
            set { chosenSeat = value; }
        }

        public PassengerView(string name, Seat chosenSeat)
        {
            this.Name = name;
            this.ChosenSeat = chosenSeat;
        }
    }
}
