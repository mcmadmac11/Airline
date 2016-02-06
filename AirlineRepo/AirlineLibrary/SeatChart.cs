using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class SeatChart
    {
        TextFileWriter writer = new TextFileWriter();
        Seat seat1 = new Seat("A", 300, true);
        Seat seat2 = new Seat("B", 200, true);
        Seat seat3 = new Seat("C", 300, true);
        public Seat[] SeatRow = new Seat[3];
        public Dictionary<int, Seat[]> AirplaneSeating;
        public int NumberOfRows;


        public Dictionary<int, Seat[]> SeedSeatChart(int numberOfRows)
        {
            this.AirplaneSeating = new Dictionary<int, Seat[]>();
            this.NumberOfRows = numberOfRows;
            for (int i = 1; i <= NumberOfRows; i++)
            {
                AirplaneSeating.Add(i, new Seat[] { seat1, seat2, seat3 });
                Console.WriteLine(string.Format("Row: {0} Seat A: {1} Seat B: {2} Seat C: {3}", i, seat1.isAvailable, seat2.isAvailable, seat3.isAvailable));

            }
            
            return AirplaneSeating;
        }
        public List<Seat[]> AddToList(Dictionary<int, Seat[]> flightSeating)
        {
            flightSeating = AirplaneSeating;
            List<Seat[]> SeatList = new List<Seat[]>();
            SeatList = flightSeating.Values.ToList();
            foreach (Seat[] row in SeatList)
            {
                Console.WriteLine(string.Format("{0}|{1}|{2}", seat1.seatNumber, seat2.seatNumber, seat3.seatNumber));      
            }
            
            return SeatList;
        }

        public override string ToString()
        {
            return (string.Format("{0}|{1}|{2}", seat1.seatNumber, seat2.seatNumber, seat3.seatNumber));
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



