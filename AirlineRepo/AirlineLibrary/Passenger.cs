﻿using System;
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
            this.Name = name;
            this.ChosenSeat = chosenSeat;
        }
        public Passenger()
        {
            string name;

        }

        public void BuySeat(Passenger currentPassenger, Seat chosenSeat)
        {
            currentPassenger.ChosenSeat = chosenSeat;
        }
    }
}