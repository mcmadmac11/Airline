using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineLibrary;
using Airline;

namespace WPFTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger Dan = new Passenger();
            Dan.Name = "Dan";
            Seat seat = new Seat("3A", 250);
            Origin Milwaukee = new Origin("Milwaukee");
            Destination SanDiego = new Destination("San Diego");
            AirPlane airplane = new AirPlane();
            Itinerary<object> itinerary = new Itinerary<object>(Milwaukee,SanDiego,airplane,Dan,seat);
            MyFileWriter mf = new MyFileWriter();
            SeatChart seatChart = new SeatChart();
            seatChart.populateSeatChart();
            mf.WriteToFile(Dan,Milwaukee,SanDiego);   
        
            
        }
    }
}
