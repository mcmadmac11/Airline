﻿using System;
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
            SeatChart sec = new SeatChart();
            sec.SeedSeatChart(10);
            sec.CheckTicketAvailability(sec.AirplaneSeating);
            Console.WriteLine(sec.AirplaneSeating.Keys);
            //Passenger Dan = new Passenger();
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
            Console.ReadLine();   
        
            
        }
    }
}
