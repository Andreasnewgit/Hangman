using System;
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
            int wordListVerify = random.Next(0, wordlist.Length);
            string hangManWord = wordlist[wordListVerify];

            Console.WriteLine(hangManWord);

            Console.WriteLine("The word has {0} characters", hangManWord.Length);

            foreach (char x in hangManWord)
            {
                Console.Write("_");
            }

            // Attempts for guessing the correct word
            int tenAttempts = 10;
         

            StringBuilder sb = new StringBuilder();

            while (tenAttempts > 0)
            {
                Console.WriteLine("\nGuesses left: {0}", tenAttempts);
            
                // Gets user input and limits input to 1 character only
                Console.Write("Enter a single letter: ");                           
                char[] input = Console.ReadLine().ToCharArray();
               
                string guess = "";
                if (input.Length > 0)
                {
                    guess = input[0].ToString();
                    guess = guess.ToLower();
                }

                if (hangManWord.Contains(guess))
                {
                    Console.WriteLine("Correct, this letter is in the word!", guess);
                    char[] correctGuess = guess.ToCharArray();
                    
                    for (int i = 0; i < correctGuess.Length; i++)
                    {
                        Console.WriteLine(correctGuess[i]);
                    }
                }

                else
                {
                    Console.WriteLine("The Letter {0} is not in the word", guess);

                    sb.Append(guess);            
                    String[] incorrectGuesses = sb.ToString().Split(",");
                    for (int i = 0; i < sb.Length; i++)
                        Console.Write(sb[i]);
                 
                    tenAttempts--;
                }
            }
              endOfGameScreen(tenAttempts);
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




//var runProgram = true;
//while (runProgram)

//{
//    Console.WriteLine("Hangman Game Title \n");
//    Console.WriteLine("Press 1 for + Addition");
//    Console.WriteLine("Press 2 for - Subtraction");

//    Console.WriteLine("Press 11 to stop playing");
//    var userInput = Console.ReadLine();




//    switch (userInput)
//    {
//        case "1":
//            Console.WriteLine("    Hangman");
//            Console.WriteLine(" _____________");
//            Console.WriteLine(" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(" |");
//            Console.WriteLine("_|_");
//            break;

//        case "2":
//            Console.WriteLine(" ______________");
//            Console.WriteLine(" |/");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(" |");
//            Console.WriteLine("_|_");
//            break;

//        case "3":
//            Console.WriteLine(" _______________");
//            Console.WriteLine(" |/");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(" |");
//            Console.WriteLine("_|_");
//            break;

//        case "4":
//            Console.WriteLine(" _______________");
//            Console.WriteLine(" |/            |");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(" |");
//            Console.WriteLine("_|_");
//            break;

//        case "5":
//            Console.WriteLine(" _______________");
//            Console.WriteLine(" |/            |");
//            Console.WriteLine(" |             0");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(" |");
//            Console.WriteLine("_|_");
//            break;

//        case "6":
//            Console.WriteLine(" _______________");
//            Console.WriteLine(" |/            |");
//            Console.WriteLine(" |             0");
//            Console.WriteLine(@" |            /");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(" |");
//            Console.WriteLine("_|_");
//            break;

//        case "7":
//            Console.WriteLine(" _______________");
//            Console.WriteLine(" |/            |");
//            Console.WriteLine(" |             0");
//            Console.WriteLine(@" |            /|");
//            Console.WriteLine(" |");
//            Console.WriteLine(@" |");
//            Console.WriteLine(" |");
//            Console.WriteLine(" |");
//            Console.WriteLine("_|_");
//            break;

//        case "8":
//            Console.WriteLine(" _______________");
//Console.WriteLine(" |/            |");
//Console.WriteLine(" |             0");
//Console.WriteLine(@" |            /|\");
//Console.WriteLine(" |");
//Console.WriteLine(@" |");
//Console.WriteLine(" |");
//Console.WriteLine(" |");
//Console.WriteLine("_|_");
//break;

//        case "9":
//Console.WriteLine(" _______________");
//Console.WriteLine(" |/            |");
//Console.WriteLine(" |             0");
//Console.WriteLine(@" |            /|\");
//Console.WriteLine(" |             |");
//Console.WriteLine(@" |             ");
//Console.WriteLine(" |");
//Console.WriteLine(" |             Last guess");
//Console.WriteLine("_|_            Make it count");
//break;

//        case "10":
//            Console.WriteLine(" _______________");
//            Console.WriteLine(" |/            |");
//            Console.WriteLine(" |             X");
//            Console.WriteLine(@" |            /|\");
//            Console.WriteLine(" |             |");
//            Console.WriteLine(@" |             /\");
//            Console.WriteLine(" |");
//            Console.WriteLine(" |             RIP");
//            Console.WriteLine("_|_            HANGED");
//            break;


//        case "11":
//            runProgram = false;
//            Console.WriteLine("Program have ended");

//            break;
//    }
//}
