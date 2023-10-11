using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {


           //string filePath = "C: \\Users\\edwar\\Downloads\\WordUnscrambler_Startup_Code\\WordUnscrambler_Startup_Code\\WordFile"; 

            try
            {
                string content = File.ReadAllText(filePath);
                //Console.WriteLine("File content:\n" + content);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

           
            return null;
        }
    }
}
