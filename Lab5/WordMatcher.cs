using System;
using System.Collections.Generic;

namespace WordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();

            foreach (string sw in scrambledWords)
            {
                foreach (string w in wordList)
                {
                    char[] scrambledWord = sw.ToCharArray();
                    char[] word = w.ToCharArray();

                    Array.Sort(scrambledWord);
                    Array.Sort(word);

                    string sortedScrambledWord = new string(scrambledWord);
                    string sortedWord = new string(word);

                    if (sortedScrambledWord == sortedWord)
                    {
                        matchedWords.Add(BuildMatchedWord(w, sw));
                    }
                }
            }

            // Implement code here.
            // Work with "scrambledWords" and "matchedWords.

            return matchedWords;
        }

        MatchedWord BuildMatchedWord(string scrambledWord, string word)
        {
            return new MatchedWord(scrambledWord, word);
        }
    }
}
