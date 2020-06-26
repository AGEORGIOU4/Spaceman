using System;

namespace Spaceman
{
    class Game
    {
        // FIELDS
        private string player;
        private string codeWord;
        private string currentWord;
        private int numberOfGuesses;
        private int currentNumberOfWrongGuesses;
        private string[] options;
        private Ufo u = new Ufo();

        // CONSTRUCTORS
        public Game(string codeWord = "secret", string currentWord = "hello", int numberOfGuesses = 5, int currentNumberOfWrongGuesses = 0)
        {
            string[] options = new string[] { "abcdef", "ghijk" };
            codeWord = options[1];
            numberOfGuesses = 5;
            currentNumberOfWrongGuesses = 0;
            currentWord = "_____";
        }

        // PROPERTIES

        // METHODS
        public void GetName()
        {
            Console.WriteLine("What's your name?");
        }
        public void Greet()
        {
            player = Console.ReadLine();
            Console.WriteLine($"Hello {player}!");
        }

        public Boolean DidWin()
        {
            if (codeWord.Equals(currentWord))
            {
                return true;
            }
            else
                return false;
        }

        public Boolean DidLose()
        {
            if (currentNumberOfWrongGuesses > numberOfGuesses)
            {
                return true;
            }
            else
                return false;
        }

        public void Display()
        {
            Console.WriteLine(u.Stringify());
            Console.WriteLine(currentWord);
            Console.WriteLine(numberOfGuesses - currentNumberOfWrongGuesses);
        }

        public void Ask()
        {
            Console.WriteLine("Guess a letter");
            string letter = Console.ReadLine();

            if (letter.Length != 1)
            {

            }

        }
    }
}