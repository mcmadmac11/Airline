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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Airline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void book_flight_button_Click(object sender, RoutedEventArgs e)
        {
            BookFlightWindow bookFlightWindow = new BookFlightWindow();
            bookFlightWindow.Show();
            

        }

        private void view_itinerary_button_Click(object sender, RoutedEventArgs e)
        {
            ViewItineraryWindow viewItineraryWindow = new ViewItineraryWindow();
            viewItineraryWindow.Show();

        }
    }
}
