using Lab5;
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

                    extensionclass extensionclass = new extensionclass();


                    if(extensionclass.sortWord(scrambledWord, word) == true)
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


