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
using System.ComponentModel;


namespace Airline
{
    /// <summary>
    /// Interaction logic for BookFlightWindow.xaml
    /// </summary>    
    public partial class BookFlightWindow : Window 
    {
        

        public BookFlightWindow()
        {
            InitializeComponent();
            EventModel _event = new EventModel() { };
            this.DataContext = _event;
        }

        private void EventDate_CalendarClosed(object sender, RoutedEventArgs e)
        {
            EventModel _event = new EventModel();
            this.DataContext = _event;
        }

        private void EventDate_CalendarOpened(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EventModel _event = new EventModel();
            this.DataContext = _event;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are you sure you want to confirm this flight?");

        }
    }
}
