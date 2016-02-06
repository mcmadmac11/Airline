using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineLibrary;
using Airline;
using System.IO;
using System.Collections.Concurrent;
using System.Data.Common;
using System.Data;

 //Each flight will have:  * Flight object contains flightList with data below
//o An aircraft assigned to it
//        o Flight number
//        o Origin
//        o Destination
//        o Passenger manifest.
//    - You need the ability to sell a seat on any given flight
//        o Each seat on a flight should have a price
//        o When selling a seat, the passengers information should be added to the passenger manifest

namespace WPFTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Seat seat = new Seat("1A", 300, false);
            SeatChart seed = new SeatChart();
            seed.AddToList(seed.SeedSeatChart(5));
            List<Passenger> flightManifest = new List<Passenger>();
            Passenger initPassenger = new Passenger("", seat);
            flightManifest.Add(initPassenger);

            //passenger chooses origin/destination
            //passenger buys ticket

            //Repeat to fill plane
            // create seatchart for flight
            Origin origin = new Origin("Lima,Peru");
            Destination destination = new Destination("Bogota,Columbia");

            //create flight/airplane
            AirPlane airplane = new AirPlane(100, 300, true, "schedule");
            Flight flight = new Flight(airplane, 4345, origin, destination, flightManifest);




            //


            TextWriter writer = new StreamWriter("Manifest.txt", true);
            writer.Write(seat.getSeatName());
            writer.Close();
            
            




            //Dan.Name = "Dan";
            //Seat seat1 = new Seat("A1", 300, true);
            //Origin Milwaukee = new Origin("Milwaukee");
            //Destination SanDiego = new Destination("San Diego");
            //AirPlane airplane = new AirPlane();
            //Itinerary<object> itinerary = new Itinerary<object>(Milwaukee,SanDiego,airplane,Dan,seat1);
            //MyFileWriter mf = new MyFileWriter();
            //SeatChart seatChart = new SeatChart();
            //Passenger Adam = new Passenger("Adam",seat1);
            //seatChart.populateSeatChart();
            //seatChart.BuySeat(Adam);
            //seatChart.GetAvailableSeats();
            //Console.WriteLine(Adam.ChosenSeat.getSeatName());
            //mf.WriteToFile(Dan,Milwaukee,SanDiego);
 
        
            
        }
    }
}
