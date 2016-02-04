using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AirlineLibrary;

namespace Airline
{
    /// <summary>
    /// Interaction logic for ViewItineraryWindow.xaml
    /// </summary>
    public partial class ViewItineraryWindow : Window
    {
        public AirPlane airPlane = new AirPlane(30, 120, true, "Kanto to Johto");
        public List<Passenger> passengerManifest = new List<Passenger>();
        public string myOrigin = "Kanto";
        public string myDestination = "Johto";
        Seat seat = new Seat(null, 300, true);
        Passenger passenger = new Passenger("Adam",null);
        

        public ViewItineraryWindow()
        {
            InitializeComponent();
            Itinerary myItinerary = new Itinerary(myOrigin, myDestination, airPlane, passenger, seat) { originationCity = myOrigin, destinationCity = myDestination, plane = airPlane, traveler = passenger, assignedSeat = seat };
            this.DataContext = myItinerary;
            //passengerManifest.Add(passenger);
            //Flight myFlight = new Flight(airPlane, 101, myOrigin, myDestination, passengerManifest) {m};

            //this.DataContext = myFlight;
            //PassengerView Passenger = new PassengerView("Adam", null) { Name = "Adam", ChosenSeat = null };
            //Origin origin = new Origin("Kanto") { FlightOrigin = "Kanto" };
            //this.DataContext = Passenger;
            //this.DataContext = origin;
        }
    }
}
        //Flight myFlight = new Flight(AirPlane airPlane, int flightNumber, Origin origin, Destination destination, List < Passenger > passengerManifest);
        //        SeatConfig = new Seat[10, 3];
        //        Seat A1 = new Seat("A1", 300, true);
        //        Seat A2 = new Seat("A2", 300, true);
        //        Seat A3 = new Seat("A3", 300, true);
        //        Seat B1 = new Seat("B1", 200, true);
        //        Seat B2 = new Seat("B2", 200, true);
        //        Seat B3 = new Seat("B3", 200, true);
        //        Seat C1 = new Seat("C1", 100, true);
        //        Seat C2 = new Seat("C2", 100, true);
        //        Seat C3 = new Seat("C3", 100, true);
        //        var list = new ObservableCollection<DataObject>();
        //        list.Add(new DataObject() {A = A1.getSeatName(), B = B1.getSeatName(), C = C1.getSeatName() });
        //        list.Add(new DataObject() { A = A2.getSeatName(), B = B2.getSeatName(), C = C2.getSeatName() });
        //        list.Add(new DataObject() { A = A3.getSeatName(), B = B3.getSeatName(), C = C3.getSeatName() });
        //        this.dataGrid1.ItemsSource = list;

