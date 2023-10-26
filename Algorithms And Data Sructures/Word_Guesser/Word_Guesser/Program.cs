using System;
using System.Collections.Generic;
using System.Linq;

class WordGuesser
{
    private List<string> wordList;
    private string wordToGuess;
    private int maxAttempts;
    private List<char> correctGuesses;
    private List<char> guessedLetters;

    public WordGuesser()
    {
        wordList = new List<string>
        {
            "algorithm", "variable", "function", "loop", "array", "class", "method",
            "interface", "library", "database", "debug", "exception", "namespace",
            "framework", "compiler", "syntax", "boolean", "pointer", "recursion",
            "inheritance", "polymorphism", "abstraction", "encapsulation", "instance",
            "git", "version", "code", "object", "string", "integer"
        };

        maxAttempts = 6;
        correctGuesses = new List<char>();
        guessedLetters = new List<char>();
        InitializeGame();
    }

    public void InitializeGame()
    {
        wordToGuess = wordList[new Random().Next(0, wordList.Count)];
    }

    public void Play()
    {
        char[] displayWord = new char[wordToGuess.Length];
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            displayWord[i] = '_';
        }

        Console.WriteLine("Welcome to Word Guess!");
        Console.WriteLine($"Guess the word: {new string(displayWord)}");

        while (maxAttempts > 0)
        {
            Console.Write("Enter a letter: ");
            char guess = Console.ReadLine().ToLower()[0];

            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("You've already guessed this letter.");
                continue;
            }

            guessedLetters.Add(guess);

            if (wordToGuess.Contains(guess))
            {
                Console.WriteLine("Correct guess!");
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess && displayWord[i] == '_')
                    {
                        displayWord[i] = guess;
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect guess!");
                maxAttempts--;
            }

            Console.WriteLine();
            Console.WriteLine($"Attempts left: {maxAttempts}");
            Console.WriteLine($"Current progress: {new string(displayWord)}");

            if (!displayWord.Contains('_'))
            {
                Console.WriteLine("Congratulations! You've guessed the word.");
                break;
            }
        }

        if (maxAttempts == 0)
        {
            Console.WriteLine("You've run out of attempts. The word was: " + wordToGuess);
        }
    }
}

class Program
{
    static void Main()
    {
        WordGuesser game = new WordGuesser();
        game.Play();
    }
}
