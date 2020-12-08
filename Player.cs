using System;
using static System.Console;
namespace AdventureGame
{
    public class Player
    {
        // Default character name.
        public static string CharacterName { get; set; }
        public static string Occupation { get; set; } = "Adventurer";
        public static int Gold { get; private set; } = 0;

        public Player()
            {

            }
        

        // Ask player for a name, and saves it.
        public static void NameCharacter()
        {
            WriteLine("Please Enter Character Name: ");
            ForegroundColor = ConsoleColor.Green;
            CharacterName = ReadLine();
            Title = "Character Setup";
            ResetColor();
            WriteLine($"Adventurer {CharacterName} , it is time for your journey to begin!");

        }

        public static void TradeForGold()
        {
           // Gold + {CurrentItemValue};
        }
        
    }
}
