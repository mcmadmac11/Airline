using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class UIBridge
    {
        SeatChart seatChart;
        Seat _seat = new Seat(null,300,true);
        public void ChooseSeat(string seatNumber, int price, bool isAvailable)
        {
            Seat seat = new Seat(seatNumber, price, isAvailable);
            _seat = seat;
        }
                
        public Passenger CreateNewPassenger(string Name)
        {
            Passenger newPassenger = new Passenger(Name, _seat);
            return newPassenger;
        }

        public void CreateChart(int numberOfRows)
        {
            seatChart = new SeatChart();
            seatChart.SeedSeatChart(numberOfRows);
        }
    }
}
