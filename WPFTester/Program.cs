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
            FileWriter fw = new FileWriter();
            fw.WriteToXml();
        }
    }
}
