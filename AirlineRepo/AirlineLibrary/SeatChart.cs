using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class SeatChart
    {
        public Seat[,] SeatConfig;
        public string[] seatNameLetter;
        public string[] seatNameNumber;
        public int[] seatPrice;
        public SeatChart()
        {
            SeatConfig = new Seat[10, 3];
            seatNameLetter = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            seatNameNumber = new string[3] { "1", "2", "3" };
            seatPrice = new int[3] {300, 200, 100 };
        }

        public void populateSeatChart()
        {
            for(int outsideArrayCounter = 0; outsideArrayCounter < 10; outsideArrayCounter++)
            {
                for (int insideArrayCounter = 0; insideArrayCounter < 3; insideArrayCounter++)
                {
                    SeatConfig[outsideArrayCounter, insideArrayCounter] = new Seat (seatNameLetter[outsideArrayCounter]+seatNameNumber[insideArrayCounter], seatPrice[insideArrayCounter], true);
                }
            }
        }
        
        public void GetAvailableSeats()
        {
            for (int outsideArrayCounter = 0; outsideArrayCounter < 10; outsideArrayCounter++)
            {
                for (int insideArrayCounter = 0; insideArrayCounter < 3; insideArrayCounter++)
                {
                    if(SeatConfig[outsideArrayCounter, insideArrayCounter].checkAvailability()==true)
                    {
                        string displayName = SeatConfig[outsideArrayCounter, insideArrayCounter].getSeatName();
                        Console.WriteLine(displayName);
                    }
                }
            }
        }

        public void BuySeat(Passenger passenger)
        {
            string seatName = passenger.getPassengerSeatName();
            for (int outsideArrayCounter = 0; outsideArrayCounter < 10; outsideArrayCounter++)
            {
                for (int insideArrayCounter = 0; insideArrayCounter < 3; insideArrayCounter++)
                {
                    if (SeatConfig[outsideArrayCounter, insideArrayCounter].getSeatName() == seatName && SeatConfig[outsideArrayCounter, insideArrayCounter].checkAvailability() == true)
                    {
                        passenger.ChosenSeat = SeatConfig[outsideArrayCounter, insideArrayCounter];
                        SeatConfig[outsideArrayCounter, insideArrayCounter].makeUnAvailable();
                        //SeatConfig[outsideArrayCounter, insideArrayCounter].setSeatNameNull();
                    }
                }
            }
        }
    }
}

//GetAvailableSeats();
//Console.WriteLine("what seat do you want to buy?");
// currentPassenger.ChosenSeat = SeatConfig[seatNameLetter,seatNameNumber];
//Console.WriteLine(currentPassenger.ChosenSeat);
//Seat chosenSeat = currentPassenger.ChosenSeat;
//if (chosenSeat != null)
//{
//    currentPassenger.ChosenSeat = chosenSeat;
//    chosenSeat = null;
//}
//else
//{
//    Console.WriteLine("that seat is already pearchesd");
//}



//public  getLocationInArray(Seat seat)
//{

//    for (int outsideArrayCounter = 0; outsideArrayCounter < 10; outsideArrayCounter++)
//    {
//        for (int insideArrayCounter = 0; insideArrayCounter < 3; insideArrayCounter++)
//        {

//            string displayName = SeatConfig[outsideArrayCounter, insideArrayCounter].getSeatName();
//            Console.WriteLine(displayName);
//            if(displayName==seat.getSeatName())
//            {
//                return SeatConfig[outsideArrayCounter, insideArrayCounter];
//            }

//        }
//    }
//}


