using System;

namespace Praktikum6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxWrongGuesses = 5;
            var wrongGuesses = 0;
            var word = GetWord();
            var wordGuessed = false;
            var secretWord = "";
            var guessedChars = "";

            Console.WriteLine(" Hangman\n =======");
            Console.WriteLine($" Gesucht ist ein Wort mit {word.Length} Buchstaben.");

            for (int i = 0; i < word.Length; i++)
                secretWord += "-";
            var secretWordCharArray = secretWord.ToCharArray();

            while (wrongGuesses < maxWrongGuesses && !wordGuessed)
                Guess(maxWrongGuesses, ref wrongGuesses, word, ref secretWordCharArray, ref wordGuessed, ref guessedChars);

            if (wordGuessed)
                Console.WriteLine(" Du hast gewonnen!");
            else
                Console.WriteLine(" Du hast verloren!");
        }

        /// <summary>
        /// Returns a random word from aan array.
        /// </summary>
        /// <returns></returns>
        static string GetWord()
        {
            string[] words = {"Programmieren",
                              "Praktikum",
                              "Nuernberg",
                              "Informatik",
                              "Professor",
                              "Hangman",
                              "Visualstudio",
                              "Csharp",
                              "Student",
                              "Mensateria"};

            Random random = new Random();
            string rndWord = words[random.Next(0, words.Length)];
            return rndWord;
        }
        /// <summary>
        /// writes a given word on the console.
        /// </summary>
        /// <param name="word"></param>
        static void PrintWord(string word)
        {
            Console.WriteLine("\n Das geheime Wort ist: " + word);
        }
        /// <summary>
        /// prints every letter in a word.
        /// </summary>
        /// <param name="word"></param>
        static void PrintChars(string word)
        {
            Console.Write(" Falsche Buchstaben: ");
            foreach (var element in word)
            {
                Console.Write(element + ", ");
            }
        }
        /// <summary>
        /// plays one round (1 letter) of hangman.
        /// </summary>
        /// <param name="maxGuesses"></param>
        /// <param name="wrongGuesses"></param>
        /// <param name="word"></param>
        /// <param name="secretWordCharArray"></param>
        /// <param name="wordGuessed"></param>
        /// <param name="guessedChars"></param>
        static void Guess(int maxGuesses, ref int wrongGuesses, string word, ref char[] secretWordCharArray, ref bool wordGuessed, ref string guessedChars)
        {
            PrintWord(new String(secretWordCharArray));
            PrintChars(guessedChars);
            Console.Write("\n Buchstaben eingeben: ");

            var charGuessed = false;
            var guess = Console.ReadKey().KeyChar;
            var wordCharArray = word.ToCharArray();
            var charWasAlreadyGuessed = false;

            for (int i = 0; i < wordCharArray.Length; i++) // checks every letter in the word
            {
                if (Char.ToLower(guess) == Char.ToLower(wordCharArray[i])) // Hit!
                {
                    if (!charGuessed) // pro Buchstabe nur einmal "ist richtig" ausgeben
                        Console.Write($"--> {guess} ist richtig!");

                    secretWordCharArray[i] = wordCharArray[i];
                    charGuessed = true;
                }

                foreach (var element in guessedChars) // checks if character was already falsely guessed
                    if (element == guess)
                        charWasAlreadyGuessed = true;
            }
            if (!charGuessed && !charWasAlreadyGuessed) // Wrong Guess.
            {
                wrongGuesses++;

                guessedChars += guess;
                Console.Write($"--> {guess} ist falsch!");
                Console.WriteLine($" {wrongGuesses} von {maxGuesses} Fehlern.");
            }
            else if (secretWordCharArray.ToString() == word) // Game won.
            {
                wordGuessed = true;
                PrintWord(word);
            }
        }
    }
}
