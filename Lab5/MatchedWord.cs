using System;

namespace WordUnscrambler
{
    struct MatchedWord
    {
        public string ScrambledWord { get; set; }
        public string Word { get; set; }

        // Constructor to build a matched word
        public MatchedWord(string scrambledWord, string word)
        {
            ScrambledWord = scrambledWord;
            Word = word;
        }

        // ToString to output matching words
        public override string ToString()
        {
            return $"{Word} matches {ScrambledWord}";
        }
    }
}
