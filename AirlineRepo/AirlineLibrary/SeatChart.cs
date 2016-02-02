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
        public string[] seatNameLeter;
        public string[] seatNameNumber;
        public int[] seatPrice;
        public SeatChart()
        {
            SeatConfig = new Seat[10, 3];
            seatNameLeter = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            seatNameNumber = new string[3] { "1", "2", "3" };
            seatPrice = new int[3] { 100, 200, 300 };
        }
        //public void populateSeatNameLetter()
        //{
        //    for (int counter = 0; counter < 10; counter++)
        //    {
        //        seatNameLeter[counter]=
        //    }
        //}


        public void populateSeatChart()
        {


            for(int outsideArrayCounter = 0; outsideArrayCounter < 10; outsideArrayCounter++)
            {
                for (int insideArrayCounter = 0; insideArrayCounter < 3; insideArrayCounter++)
                {
                    SeatConfig[outsideArrayCounter, insideArrayCounter] = new Seat (seatNameLeter[outsideArrayCounter]+seatNameNumber[insideArrayCounter], seatPrice[insideArrayCounter]);
                    Console.WriteLine("{0} {1}",seatNameLeter[outsideArrayCounter], seatNameNumber[insideArrayCounter]);
                }
            }
        } 
        
    }
}
