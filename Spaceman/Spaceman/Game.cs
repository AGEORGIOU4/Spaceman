using System;

namespace Spaceman
{
    class Game
    {

        //FIELDS
        private string codeword;
        private string currentword;
        private int maxNumOfGuesses;
        private int currentNumOfWrongGuesses;
        private string[] wordbank = { "code", "morse", "hello", "space", "nemo" };

        // Generate a random number between 0 and size of array
        public System.Random random = new System.Random();

        Ufo u = new Ufo();

        //CONSTRUCTORS
        public Game()
        {
            codeword = wordbank[random.Next(wordbank.Length)];
            maxNumOfGuesses = 5;
            currentNumOfWrongGuesses = 0;

            for (int i = 0; i < codeword.Length; i++)
            {
                currentword += "_";
            }

        }

        //METHODS
        public void Greet()
        {
            Console.WriteLine("=============\nUFO: The Game\n=============\nInstructions: save your friend from alien abduction by guessing the letters in the codeword.");
        }

        public void Display()
        {
            Console.WriteLine(u.Stringify());
            Console.WriteLine($"Current word: {currentword}\n");
            Console.WriteLine("Number of guesses remaining: " + (maxNumOfGuesses - currentNumOfWrongGuesses));
        }

        public void Ask()
        {
            // Ask user to enter a letter and capture it
            Console.WriteLine("Enter a letter: ");
            string letter = Console.ReadLine();

            if (letter.Length > 1 || letter.Length == 0)
            {
                Console.WriteLine("Please input one letter at a time!");
                return;
            }

            char guess = letter.Trim().ToCharArray()[0];

            if (codeword.Contains(guess))
            {
                Console.WriteLine($"{guess} is in the word!");
                for(int index = 0; index < codeword.Length; index++)
                {
                    if(guess == codeword[index])
                    {
                        currentword = currentword.Remove(index, 1).Insert(index, letter);
                    }
                }              
            }
            else
            {
                Console.WriteLine($"'{letter}' is not in the word!");
                currentNumOfWrongGuesses++;
                u.AddPart();
            }
        }

        public bool DidWin()
        {
            if (codeword.Equals(currentword))
            {
                Console.WriteLine(codeword);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DidLose()
        {
            if (currentNumOfWrongGuesses >= maxNumOfGuesses)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}