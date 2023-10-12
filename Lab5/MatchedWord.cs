using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    struct MatchedWord
    {
        //Constructor to build matched word
        public MatchedWord(string scrambledWord, string word)
        {
            ScrambledWord = scrambledWord;
            Word = word;
        }

        public string ScrambledWord { get; set; }
        public string Word { get; set; }

        //ToString to output matching words
        public override string ToString()
        {
            return $"{this.Word} matches {this.ScrambledWord}";
        }
    }
}



   
