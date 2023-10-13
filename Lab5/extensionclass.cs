using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class extensionclass
    {

        public bool sortWord(char[] word , char[] scrambledword)
        {
            Array.Sort(scrambledword);
            Array.Sort(word);

            string sortedScrambledWord = new string(scrambledword);
            string sortedWord = new string(word);


            if(sortedScrambledWord == sortedWord)
            {

                return true;
            }

            return false;

        }
    }
}
