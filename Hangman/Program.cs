using System;
using System.Data;
using System.Text;

namespace Hangman
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] wordlist =
            {
                "thermos",
                "mobile",
                "earphones",
                "bluetooth",
                "keyboard",
                "monitor",
                "computer",
                "whiteboard",
                "ceiling",
                "headphones",
                "network",
            };

            // Randomly picks a word from the list and assigns it to var hangManWord
            Random random = new Random();
            int wordListRandom = random.Next(0, wordlist.Length);
            string hangManWord = wordlist[wordListRandom];

            Console.WriteLine(hangManWord);

            Console.WriteLine("The word has {0} characters", hangManWord.Length);
       
            // Attempts for guessing the correct word
            int gameGuesses = 10;

            var letters = new List<string>();
            StringBuilder sb = new StringBuilder();

            while (gameGuesses > 0)
            {
                var charactersLeft = 0;
                // loops through all characters in the word
                foreach (var character in hangManWord)
                {
                    var letter = character.ToString();  
                    if (letters.Contains(letter))
                    {
                       Console.Write(letter);
                    }
                    else
                    {
                        Console.Write("_");
                        charactersLeft++;
                    }
                }
                Console.WriteLine(String.Empty);

                if (charactersLeft == 0)
                {
                    break;
                }

                Console.WriteLine("Type in a letter or guess the whole word \n");

                var key = Console.ReadLine().ToString().ToLower();
                Console.WriteLine(string.Empty);
                Console.WriteLine("Letters guessed so far: " + sb);               

                if (letters.Contains(key))
                {
                    Console.WriteLine("Letter have already been entered");
                    sb.Append(key);                  
                    continue;
                }
                letters.Add(key);

                if (!hangManWord.Contains(key))
                {
                    gameGuesses--;
                    if(gameGuesses > 0)
                    {
                        Console.WriteLine($"The letter {key} is not in the word. " +
                        $"You have {gameGuesses} guesses left.");
                        sb.Append(key);                    
                    }
                    else
                    {
                        endOfGameScreen(gameGuesses);
                    }
                }           
            }                  
        }

        private static void endOfGameScreen(int tenAttempts)
        {
            if (tenAttempts == 0)
            {
                Console.WriteLine("\nNo more guesses!");
                Console.WriteLine(" _______________");
                Console.WriteLine(" |/            |");
                Console.WriteLine(" |             X");
                Console.WriteLine(@" |            /|\");
                Console.WriteLine(" |             |");
                Console.WriteLine(@" |            / \");
                Console.WriteLine(" |");
                Console.WriteLine(" |             RIP");
                Console.WriteLine("_|_            HANGED");
            }
        }
    }
}

