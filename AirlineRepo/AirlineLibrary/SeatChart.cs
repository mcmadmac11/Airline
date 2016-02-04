using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class SeatChart
    {
        Seat seat1 = new Seat();
        Seat seat2 = new Seat();
        Seat seat3 = new Seat();
        public Dictionary<int, Seat[]> AirplaneSeating = new Dictionary<int, Seat[]>();
        public int NumberOfRows;
        public bool IsAvailable = true;
        public void SeedSeatChart(int numberOfRows)
        {
            seat1.isAvailable = false;
            this.NumberOfRows = numberOfRows;
            for (int i = 1; i <= NumberOfRows; i++)
            {
                AirplaneSeating.Add(i, new Seat[] { seat1, seat2, seat3 });
            }
            foreach (KeyValuePair<int, Seat[]> kvp in AirplaneSeating)
            {
                Console.WriteLine(string.Format("Row:{0} Seat A:{1} B:{2} C:{3} ", kvp.Key, kvp.Value[0].isAvailable, kvp.Value[1].isAvailable, kvp.Value[2].isAvailable));
                string SeatingConfiguration = Console.ReadLine();
                Console.WriteLine(SeatingConfiguration);
            }

        }
        public void CheckTicketAvailability(Dictionary<int, Seat[]> flightSeating)
        {

            for (int i = 0; i < AirplaneSeating.Values.Count; i++)
            {
                int index = i;
                foreach (KeyValuePair<int, Seat[]> kvp in AirplaneSeating)
                {
                    if (kvp.Value[index].isAvailable != true)
                    {
                        Console.WriteLine("I'm Sorry, that seat is not available for this flight.  Please select again");
                    }

                }
            }

        }
    }
}



//foreach (var item in availabilityCheck.Select((value, index) => new { value, index }))
//{
//    string currentValue;
//    int currentIndex = item.index;
//    if (item.value == true) { currentValue = "Available"; }
//    else { currentValue = null; }

//    {
//        Console.WriteLine(currentIndex + currentValue);
//    }

//}


//public Seat[,] SeatConfig;
//public string[] seatNameLetter;
//public string[] seatNameNumber;
//public int[] seatPrice;
//public SeatChart()
//{
//SeatConfig = new Seat[10, 3];
//seatNameLetter = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
//seatNameNumber = new string[3] { "1", "2", "3" };
//seatPrice = new int[3] {300, 200, 100 };
//}

//public void populateSeatChart()
//{
//    for(int i = 0; i < 10; i++)
//    {
//        for (int x = 0; x < 3; x++)
//        {
//            SeatConfig[i, x] = new Seat (seatNameLetter[i]+seatNameNumber[x], seatPrice[x], true);
//        }
//    }
//}

//public void GetAvailableSeats()
//{
//    for (int i = 0; i < 10; i++)
//    {
//        for (int x = 0; x < 3; x++)
//        {
//            if(SeatConfig[i, x].checkAvailability()==true)
//            {
//                string displayName = SeatConfig[i, x].getSeatName();
//                Console.WriteLine(displayName);
//            }
//        }
//    }
//}

//public void BuySeat(Passenger passenger)
//{
//    string seatName = passenger.getPassengerSeatName();
//    for (int i = 0; i < 10; i++)
//    {
//        for (int x = 0; x < 3; x++)
//        {
//            if (SeatConfig[i, x].getSeatName() == seatName && SeatConfig[i, x].checkAvailability() == true)
//            {
//                passenger.ChosenSeat = SeatConfig[i, x];
//                SeatConfig[i, x].makeUnAvailable();
//            }
//        }
//    }
//}



