using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    for(int i = 0; i  < scrambledWord.Length; i++)
                    {
                        if (scrambledWord[i] != word[i])
                        {
                            break;
                        }
                    }

                    matchedWords.Add(new MatchedWord(word.ToString());

                   
                }
            }
            // Implement code here.
            // Work with "scrambledWords" and "matchedWords".

            MatchedWord BuildMatchedWord(string scrambledWord, string word)
            { }
                // Build a mat ched-word object here, so that you can return it.

                //return matchedWord;
                return new MatchedWord();  // Delete this line when done.
            }

            return matchedWords;
        } 
    }

}
