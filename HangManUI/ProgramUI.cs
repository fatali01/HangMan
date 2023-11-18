namespace HangManUI;

using HangmanData.Content;
using HangmanRepo;

public class ProgramUI
{
    public void PlayHangman()
    {
        StickMan player = new StickMan(5);

        HangmanRepository repo = new HangmanRepository();

        string chosenWord = repo.GetRandomEnumValue();

        char[] guessedLetters = new string('_', chosenWord.Length).ToCharArray();

        while (player.Lives != 0)
        {
            char guess = repo.GetUserInput();

            if (chosenWord.Contains(guess))
            {
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (chosenWord[i] == guess)
                    {
                        guessedLetters[i] = guess;
                    }
                }
            }
            else
            {
                System.Console.Write("That is not a letter in the word");
                player.Lives--;
                System.Console.WriteLine($"you have lost a life, {player.Lives} lives left");
            }

            string guessedWord = string.Join(" ",guessedLetters);
            if ((guessedWord) == chosenWord)
            {
                System.Console.WriteLine($"Congratulations, you have figured out the word {guessedWord} with {player.Lives}'s left!");
                break;
            }
            else
            {
                System.Console.WriteLine(guessedWord);
            }
        }
    }
}