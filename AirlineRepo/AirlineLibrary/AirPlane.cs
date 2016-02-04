using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class AirPlane
    {

        public int PassengerCapacity;
        public int passengerCapacity
        {
            get { return PassengerCapacity; }
            set { PassengerCapacity = value; }
        }

        public int Range;

        public int range
        {
            get { return Range; }
            set { Range = value; }
        }

        public bool MaintenanceStatus;

        public bool maintenanceStatus
        {
            get { return MaintenanceStatus; }
            set { MaintenanceStatus = value; }
        }

        public string Schedule;

        public string schedule
        {
            get { return Schedule; }
            set { Schedule = value; }
        }
        public AirPlane(int passengerCapacity, int range, bool maintenanceStatus, string schedule)
        {
            this.PassengerCapacity = passengerCapacity;
            this.Range = range;
            this.MaintenanceStatus = maintenanceStatus;
            this.Schedule = schedule;
        }
        //public AirPlane()
        //{

        //}
    }
}
