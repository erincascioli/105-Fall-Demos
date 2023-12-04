
// Erin Cascioli
// 11/21/22
// PE: Completed Exception Handling PE


using System;

namespace Backpack_PE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable setup:
            Random generator = new Random();
            string npcName_1 = "Dash";
            string npcName_2 = "Bandit";

            // Variables needed for switch statement/menu loop:
            string menuOption = "";
            string stolenItem = "";
            double randomNPC = 0;

            // Variables needed to run game:
            Backpack dashPack = null;
            Backpack banditPack = null;
            List<string> stolenItems = null;

            dashPack = new Backpack(npcName_1);
            banditPack = new Backpack(npcName_2);
            stolenItems = new List<string>();


            // Inspect items in each pack
            dashPack.PrintPackContents();
            banditPack.PrintPackContents();
            Console.WriteLine("-----------------------------");


            // Insert items into the two backpacks
            dashPack.AddToPack("catnip");
            dashPack.AddToPack("treats");
            dashPack.AddToPack("cat toy");

            banditPack.AddToPack("bone");
            banditPack.AddToPack("peanut butter");
            banditPack.AddToPack("tennis ball");
            banditPack.AddToPack("frisbee");
            Console.WriteLine("-----------------------------");


            // Inspect items in each pack again!
            dashPack.PrintPackContents();
            banditPack.PrintPackContents();
            Console.WriteLine("-----------------------------");


            // Menu Loop for the program
            while (menuOption != "QUIT")
            {
                // Get the user's choice of the 5 menu options
                menuOption = GetMenuOption();

                // Run the chosen menu option
                switch (menuOption)
                {
                    // Menu Option: PRINT
                    // Prints the backpack contents of both NPCs
                    case "PRINT":
                        dashPack.PrintPackContents();
                        banditPack.PrintPackContents();
                        break;

                    // Menu Option: STEAL
                    // Prompts for a specific NPC and item, then steals that item.
                    case "STEAL":
                        string chosenNPC = GetNPCChoice(npcName_1, npcName_2);
                        int chosenIndex = GetIndexChoice(chosenNPC);

                        try
                        {

                            // Get the item from specified NPC's pack
                            if (chosenNPC == dashPack.Owner.ToUpper())
                            {
                                stolenItem = dashPack.GetItemInSlot(chosenIndex);
                            }
                            else if (chosenNPC == banditPack.Owner.ToUpper())
                            {
                                stolenItem = banditPack.GetItemInSlot(chosenIndex);
                            }

                            // And add it to this list of stolen items/confirm it was stolen
                            stolenItems.Add(stolenItem);
                            Console.WriteLine(
                                "'{0}' stolen from slot {1} in {2}'s backpack!",
                                stolenItem, chosenIndex, chosenNPC);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    // Menu Option: RANDOM
                    // Prompts for a specific NPC and item, then steal that item.
                    case "RANDOM":
                        randomNPC = generator.NextDouble();

                        // Get the item from a random NPC's pack
                        try
                        {
                            if (randomNPC < 0.5)
                            {
                                stolenItem = dashPack.GetRandomItem();
                                chosenNPC = dashPack.Owner;
                            }
                            else
                            {
                                stolenItem = banditPack.GetRandomItem();
                                chosenNPC = banditPack.Owner;
                            }

                            // And add it to this list of stolen items
                            stolenItems.Add(stolenItem);
                            Console.WriteLine(
                                "'{0}' stolen from {1}'s backpack!",
                                stolenItem, chosenNPC);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    // Menu Option: ADD
                    // Adds an item to a random NPC's backpack
                    case "ADD":
                        // Get a random value between 0 and 0.999, used for randomly choosing
                        //   an NPC to insert an item into their backpack.
                        randomNPC = generator.NextDouble();

                        // Ask user for an item to insert into the backpack
                        string itemToInsert = GetItemFromUser();

                        // Inser the item into a random NPC's backpack
                        if (randomNPC < 0.5)
                        {
                            dashPack.AddToPack(itemToInsert);
                        }
                        else
                        {
                            banditPack.AddToPack(itemToInsert);
                        }
                        break;

                    // Menu Option: QUIT
                    // Ends the program, printing all the stuff you stole from the the NPCs.
                    case "QUIT":
                        Console.WriteLine("You stole {0} items: ", stolenItems.Count);
                        foreach (string item in stolenItems)
                        {
                            Console.WriteLine("- " + item);
                        }
                        break;
                }

                Console.WriteLine();
            }
        }


        // *******************************************************************
        // You do NOT need to change ANY of these methods!       
        // *******************************************************************

        /// <summary>
        /// Prompts a user for one of the 5 possible menu choices.
        /// Forces re-entry of invalid data.
        /// </summary>
        /// <returns>String of the chosen menu option.</returns>
        public static string GetMenuOption()
        {
            // Local variables needed for this method
            string userChoice = "";

            // Present menu to user in cyan text
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose one of the following commands:");
            Console.WriteLine("  PRINT the contents of an NPC's backpack");
            Console.WriteLine("  STEAL an item from a backpack slot");
            Console.WriteLine("  Steal a RANDOM item from their backpack");
            Console.WriteLine("  ADD an item to a backpack");
            Console.WriteLine("  Or QUIT the program");
            Console.Write("  >> ");

            // Prompt for re-entry upon invalid input
            while (userChoice != "QUIT" &&
                userChoice != "PRINT" &&
                userChoice != "STEAL" &&
                userChoice != "RANDOM" &&
                userChoice != "ADD")
            {
                // Get the user's chosen menu option in yellow
                Console.ForegroundColor = ConsoleColor.Yellow;
                userChoice = Console.ReadLine().Trim().ToUpper();

                // Print error message in red
                if (userChoice != "QUIT" &&
                userChoice != "PRINT" &&
                userChoice != "STEAL" &&
                userChoice != "RANDOM" &&
                userChoice != "ADD")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid option! Try again. >> ");
                }
            }

            // Reset text color back to white
            ResetTextColor();

            // Retrieved the user's valid choice.  Return back to the program!
            return userChoice;
        }

        /// <summary>
        /// Prompts user for the name of an NPC.
        /// Forces re-entry of data until valid.
        /// </summary>
        /// <param name="npcOne">Name of the first NPC</param>
        /// <param name="npcTwo">Name of the second NPC.</param>
        /// <returns>User's chosen NPC name</returns>
        public static string GetNPCChoice(string npcOne, string npcTwo)
        {
            // Local variables needed for this method
            string userChoice = "";
            string npcOneCaps = npcOne.ToUpper();
            string npcTwoCaps = npcTwo.ToUpper();

            // Present NPC options to user in cyan text
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which NPC would you like to steal from? ");
            Console.WriteLine(" NPC one is " + npcOne.ToUpper());
            Console.WriteLine(" NPC two is " + npcTwo.ToUpper());
            Console.Write("  >> ");

            // Prompt for re-entry upon invalid input
            while (userChoice != npcOneCaps &&
                userChoice != npcTwoCaps)
            {
                // Get the user's chosen menu option in yellow
                Console.ForegroundColor = ConsoleColor.Yellow;
                userChoice = Console.ReadLine().Trim().ToUpper();

                // Print error message in red
                if (userChoice != npcOneCaps &&
                userChoice != npcTwoCaps)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid NPC! Choose another NPC. >> ");
                }
            }

            // Reset text color back to white
            ResetTextColor();

            // Retrieved the user's valid choice.  Return back to the program!
            return userChoice;
        }


        /// <summary>
        /// Prompts user for an index of a string list.
        /// Does NOT force re-entry of valid indices, as the Main method does not
        /// know how many items are in a Backpack. No error checking occurs.
        /// </summary>
        /// <param name="npcName">Name of NPC. Used for formatting output.</param>
        /// <returns>Index of an item. </returns>
        public static int GetIndexChoice(string npcName)
        {
            // Local variables needed for this method
            string userChoice = "";
            int index = 0;

            // Present NPC options to user in cyan text
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which item # would you like to steal from {0}?", npcName);
            Console.Write("  >> ");

            // Get the user's chosen index in yellow
            Console.ForegroundColor = ConsoleColor.Yellow;
            userChoice = Console.ReadLine().Trim().ToUpper();
            index = int.Parse(userChoice);

            // Reset text color back to white
            ResetTextColor();

            // Retrieved the user's valid choice.  Return back to the program!
            return index;
        }


        /// <summary>
        /// Prompts user for the name of an item to add to an NPC's backpack.
        /// </summary>
        /// <returns>String item to add.</returns>
        public static string GetItemFromUser()
        {
            // Present NPC options to user in cyan text
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter an item to add to an NPC's backpack: ");
            Console.Write("  >> ");

            // Get the user's item in yellow
            Console.ForegroundColor = ConsoleColor.Yellow;
            string userChoice = Console.ReadLine().Trim();

            // Reset text color back to white
            ResetTextColor();

            // Return back to program
            return userChoice;
        }


        /// <summary>
        /// Resets the console text to white.
        /// </summary>
        public static void ResetTextColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
