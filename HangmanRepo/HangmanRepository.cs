using HangmanData.Enums;
using HangManUI;
namespace HangmanRepo;

public class HangmanRepository
{
    public string GetRandomEnumValue()
    {
        Array values = Words.GetValues(typeof(Words));
        Random chosen = new Random();
        int randomChosenIndex = chosen.Next(values.Length);
        return values.GetValue(randomChosenIndex).ToString();
    }

    // public Words ShowRandomValue()
    // {
    //     Words ChosenWord = GetRandomEnumValue();

    //     System.Console.WriteLine(ChosenWord);
    // }
    public void PressAnyKey()
    {
        System.Console.WriteLine("Press Any Key to Continue..");
        System.Console.ReadKey();
    }

    public char GetUserInput()
    { 
        Console.Write("Guess a letter: ");
        char guess = Console.ReadLine()[0];

        return guess;
    }
    
    public void YouWin(string guessedWord, int Lives)
    {
        System.Console.WriteLine($"Congratulations, you have figured out the word {guessedWord} with {Lives}'s left!");
    }

}
