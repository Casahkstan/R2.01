using System.Reflection;
using TP01;

namespace TheHangman
{
    class Program
    {
        private static void WriteErrors(int errors)
        {
            switch (errors)
            {
                case 10:
                    Console.WriteLine("   ,==========Y===");
                    Console.WriteLine("   ||  /      |");
                    Console.WriteLine("   || /       |");
                    Console.WriteLine("   ||/        O");
                    Console.WriteLine("   ||        /|\\");
                    Console.WriteLine("   ||        /\\");
                    Console.WriteLine("   ||------\\     /---");
                    Console.WriteLine("  /||");
                    Console.WriteLine(" //||");
                    break;
                case 9:
                    Console.WriteLine("   ,==========Y===");
                    Console.WriteLine("   ||  /      |");
                    Console.WriteLine("   || /       |");
                    Console.WriteLine("   ||/        O");
                    Console.WriteLine("   ||        /|\\");
                    Console.WriteLine("   ||        /\\");
                    Console.WriteLine("   ||----------------");
                    Console.WriteLine("  /||");
                    Console.WriteLine(" //||");
                    break;
                case 8:
                    Console.WriteLine("   ,==========Y===");
                    Console.WriteLine("   ||  /      |");
                    Console.WriteLine("   || /       |");
                    Console.WriteLine("   ||/        O");
                    Console.WriteLine("   ||        /|\\");
                    Console.WriteLine("   ||         \\");
                    Console.WriteLine("   ||----------------");
                    Console.WriteLine("  /||");
                    Console.WriteLine(" //||");
                    break;
                case 7:
                    Console.WriteLine("   ,==========Y===");
                    Console.WriteLine("   ||  /      |");
                    Console.WriteLine("   || /       |");
                    Console.WriteLine("   ||/        O");
                    Console.WriteLine("   ||        /|\\");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||----------------");
                    Console.WriteLine("  /||");
                    Console.WriteLine(" //||");
                    break;
                case 6:
                    Console.WriteLine("   ,==========Y===");
                    Console.WriteLine("   ||  /      |");
                    Console.WriteLine("   || /       |");
                    Console.WriteLine("   ||/        O");
                    Console.WriteLine("   ||        /|");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||----------------");
                    Console.WriteLine("  /||");
                    Console.WriteLine(" //||");
                    break;
                case 5:
                    Console.WriteLine("   ,==========Y===");
                    Console.WriteLine("   ||  /      |");
                    Console.WriteLine("   || /       |");
                    Console.WriteLine("   ||/        O");
                    Console.WriteLine("   ||         |");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||----------------");
                    Console.WriteLine("  /||");
                    Console.WriteLine(" //||");
                    break;
                case 4:
                    Console.WriteLine("   ,==========Y===");
                    Console.WriteLine("   ||  /      |");
                    Console.WriteLine("   || /       |");
                    Console.WriteLine("   ||/        O");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||----------------");
                    Console.WriteLine("  /||");
                    Console.WriteLine(" //||");
                    break;
                case 3:
                    Console.WriteLine("   ,==========Y===");
                    Console.WriteLine("   ||  /      |");
                    Console.WriteLine("   || /       |");
                    Console.WriteLine("   ||/         ");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||----------------");
                    Console.WriteLine("  /||");
                    Console.WriteLine(" //||");
                    break;
                case 2:
                    Console.WriteLine("   ,==========Y===");
                    Console.WriteLine("   ||  /      ");
                    Console.WriteLine("   || /       ");
                    Console.WriteLine("   ||/         ");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||");
                    Console.WriteLine("  /||");
                    Console.WriteLine(" //||");
                    break;
                case 1:
                    Console.WriteLine("   , ");
                    Console.WriteLine("   ||        ");
                    Console.WriteLine("   ||        ");
                    Console.WriteLine("   ||         ");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||          ");
                    Console.WriteLine("   ||");
                    Console.WriteLine("   ||");
                    Console.WriteLine("   ||");
                    break;
            }

            Console.WriteLine("============____________________________");
        }

        static void Main()
        {
            Assembly ass = typeof(Program).GetTypeInfo().Assembly;
            Stream stream = ass.GetManifestResourceStream("TheHangman.dico.txt");
            WordBase words = new WordBase(stream);
            Hangman game = new Hangman(words);

            Console.WriteLine("Welcome to the Hangman game !");
            Console.Write("Would you like to play ?");
            string rep = Console.ReadLine()?.ToLower();

            while (rep == "o" || rep == "oui" || rep == "y" || rep == "yes")
            {
                game.StartGame();
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Letters proposed : " + game.LettersProposed);
                    WriteErrors(game.Errors);
                    //Console.WriteLine("Errors : {0}", game.Errors);
                    Console.WriteLine("Word to find : " + game.PartialWord);
                    Console.WriteLine("Your proposal : ");
                    char letter = Console.ReadKey().KeyChar;
                    game.Propose(letter);
                } while (!game.IsGameLost && !game.IsGameWon);

                Console.WriteLine();
                if (game.IsGameLost)
                {
                    WriteErrors(game.Errors);
                    Console.WriteLine("You lost ! the word was " + game.HiddenWord);
                }
                else
                {
                    Console.WriteLine(game.HiddenWord + ", good job !");
                }

                Console.Write("Would you like to play again ?");
                rep = Console.ReadLine()?.ToLower();
            }
        }
    }
}