using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class AirPlane
    {
        int PassengerCapacity;
        int Range;
        bool MaintenanceStatus;
        string Schedule;
        public AirPlane(int passengerCapacity, int range, bool maintenanceStatus, string schedule)
        {
            this.PassengerCapacity = passengerCapacity;
            this.Range = range;
            this.MaintenanceStatus = maintenanceStatus;
            this.Schedule = schedule;
        }
    }
}
