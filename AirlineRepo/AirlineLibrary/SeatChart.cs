using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class SeatChart
    {
        public Seat[,] SeatConfig = new Seat[10, 3];
        enum seatLetter { A, B, C, D, E, F, G, H, I, J };
        public SeatChart()
        {
            
        }
        public void populateSeatChart()
        {
            for(int seatLetter = 0; seatLetter<10; seatLetter++)
            {
                for(int insideArrayCounter = 0; insideArrayCounter<3; insideArrayCounter++)
                {
                    var x = SeatConfig[seatLetter, insideArrayCounter];
                }
            }
        } 
        
    }
}
