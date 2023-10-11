using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    struct MatchedWord
    {


        public string ScrambledWord { get; set; }
        public string Word { get; set; }
    }

    //Constructor to build matched word
    public MatchedWord(string scrambledWord, string word)
    {
        ScrambledWord = scrambledWord;
        Word = word;
    }

    //ToString to output matching words
    public override string ToString()
    {
        return $"{this.Word} matches {this.ScrambledWord}";
    }
}
