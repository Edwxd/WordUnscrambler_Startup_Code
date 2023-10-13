using Lab5;
using System;
using System.Collections.Generic;
using System.Resources;

namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();

        static void Main(string[] args)
        {

            string continueChoice;

            do
            {
                try
                {
                    Console.WriteLine(en_lang.EntreForM);

                    string option;
                    do
                    {
                        option = Console.ReadLine()?.Trim()?.ToUpper();
                    } while (option == "F" && option == "M");

                    switch (option)
                    {
                        case "F":
                            Console.WriteLine(en_lang.fullpath);
                            ExecuteScrambledWordsInFileScenario();
                            break;
                        case "M":
                            Console.WriteLine(en_lang.entrewords);
                            ExecuteScrambledWordsManualEntryScenario();
                            break;
                        default:
                            Console.WriteLine(en_lang.optionnotreco);
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(en_lang.exception + ex.Message);
                }


                Console.WriteLine(en_lang.goagain);
                continueChoice = Console.ReadLine();

            } while (continueChoice == "y");
        }


        private static void ExecuteScrambledWordsInFileScenario()
        {
            string filename = Console.ReadLine();
            string[] scrambledWords = _fileReader.Read(filename);
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            string wordlist = Console.ReadLine();
            string[] wordListArray = wordlist.Split(',');
            DisplayMatchedUnscrambledWords(wordListArray);
        }

        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            // Read the list of words from the system file.
            string[] wordList = _fileReader.Read(Constants.FILENAME);

            // Call a word matcher method to get a list of structs of matched words.
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            foreach (MatchedWord matchedWord in matchedWords)
            {
                Console.WriteLine(matchedWord.ToString());
            }
        }
    }
}

