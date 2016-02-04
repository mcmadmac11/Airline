using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineLibrary;

namespace Airline
{
    public class EventModel : INotifyPropertyChanged
    {

        private BookFlightWindow _bookFlight;

        public BookFlightWindow _BookFlight
        {
            get { return _bookFlight; }
            set { _bookFlight = value; }
        }


        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                EventArgs e;
            }

            remove
            {
                
            }
        }
    }
}
