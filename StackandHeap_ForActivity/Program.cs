
// Sample "game" for use with Stack Frame dry-erase activity


namespace StackandHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initial game data
            string playerName = "Dash";
            char playerChar = 'X';
            int birthYear = 2009;
            int age = (2022 - birthYear);
            string response = null;

            // Introduce the player
            Console.WriteLine(
                $"Your name is {playerName}, born in {birthYear}," + 
                $" making you {age} years old. You are represented by an {playerChar}.");

            // Play the game if the player chooses to do so
            Console.Write($"{playerName}, do you want to play? YES or NO: ");
            response = Console.ReadLine();
            response = response.Trim();
            response = response.ToUpper();

            if (response == "YES")
            {
                DisplayInitialStory();
                DisplayGameInstructions();
                DisplayHauntedHouse(playerChar);
                DisplayMapKey(playerChar);

                // There would be more here to play an actual game :)
                // In the meantime, let's keep the window open with a C.RL
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Clever {playerName}. You know what's good for you.");
            }
        }


        public static void DisplayInitialStory()
        {
            // Clear the console of any introductory data gathering
            Console.Clear();

            // Show storyline, pausing by 3.5 seconds after each line.
            PauseProgram(1000);
            Console.WriteLine(
                "All the lights go out. You can no longer see anything around you.");
            PauseProgram(3500);
            Console.WriteLine(
                "You have no recollection of the next hour.");
            PauseProgram(2000);
            Console.WriteLine(
                ". . . . . . . . . . . . . . . . . . . . . . . . ");
            PauseProgram(2000);
            Console.WriteLine(
                "You wake up on the dark, damp floor of a stone-walled basement.");
            PauseProgram(3500);
            Console.WriteLine(
                ". . . . . . . . . . . . . . . . . . . . . . . . ");
            PauseProgram(3000);
        }


        public static void DisplayGameInstructions()
        {
            // Clear the console of all story text.
            Console.Clear();

            // Show instructions for the player
            Console.WriteLine();
            Console.WriteLine(
                "Welcome to the haunted house. \n" +
                "Your only job is to find your way out!");
        }


        public static void DisplayMapKey(char playerChar)
        {
            Console.WriteLine("Map Key:");
            Console.WriteLine($"  {playerChar}  - You");
            Console.WriteLine("  [] - Trap door");
            Console.WriteLine("  @  - Enemy");
            Console.WriteLine("  $  - Gold");
        }

        public static void DisplayHauntedHouse(char playerChar)
        {
            Console.WriteLine("Floor Map:");
            Console.WriteLine();
            Console.WriteLine($"╔═══════════════════════════════════════╗");
            Console.WriteLine($"║                                       ║");
            Console.WriteLine($"║                                       ║");
            Console.WriteLine($"║                     {playerChar}                 ║");
            Console.WriteLine($"║                                       ║");
            Console.WriteLine($"║                                       ║");
            Console.WriteLine($"║  @                                    ║");
            Console.WriteLine($"╚══════════════════╗                    ║");
            Console.WriteLine($"                   ║                    ║");
            Console.WriteLine($"                   ║                    ║═══════════╗");
            Console.WriteLine($"                   ║                    ║ @     $$$ ║");
            Console.WriteLine($"                ╔══╝                    ║═══════════╝");
            Console.WriteLine($"                ║   []                  ║");
            Console.WriteLine($"                ║                       ║");
            Console.WriteLine($"                ╚═══════════════════════╝");
        }


        public static void PauseProgram(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
    }
}