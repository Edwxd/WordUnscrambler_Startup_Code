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

            try
            {
                string content = File.ReadAllText(filename);
                string[] fullContent = content.Split(',');

                return fullContent;
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }

           
            return null;
        }
    }
}
