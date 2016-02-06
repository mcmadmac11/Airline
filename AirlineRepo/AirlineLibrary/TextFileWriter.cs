using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary
{
    public class TextFileWriter
    {
        Origin LasVegas = new Origin("Las Vegas");
        public string DataString;
        
        public void Write(string dataString)
        {

            this.DataString = dataString;
            TextWriter writer = new StreamWriter("Manifest.txt",true);
            
            


        }

    }
}
