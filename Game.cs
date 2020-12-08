using System;
using System.Collections.Generic;
using static System.Console;

namespace AdventureGame
{
    public class Game
    {
        public Game()
        {

        }

        static List<string> Inventory = new List<string>();
        public static void StartGame()
        {
            GameIntro();
            Choice();
            EndGame();
        }


        // This methood prints the game intro title and overview.
        public static void GameIntro()
        {
            Title = "Welcome to World Passage: Adventure Game!";

            ASCII.WelcomeAscii();        

            // Short overview of the game.
            WriteLine("You were a stressed overworked employee until you were hit by a truck on the way home and died!\nLoading consciousness - - - \n");
            // Welcome message.
            WriteLine("Welcome to World Passage. Right now, your soul is travelling between worlds. A higher being will be with you in a moment.\n");

            Player.NameCharacter();
            WriteLine("Upload Complete");
            Utility.Continue();
            Clear();
        }



        //  ===================  Start OF SENARIOS  ===========================
        // Will track the number of senarios 
        static int Scenarios = 3;
        static string[] PartOne = {
            
            //Description of the senario.
            // PartOne [0]
            $"Hello, {Player.CharacterName} I am what you call a ‘God’ in your world. Due to an\n error on my part, you have died earlier than scheduled. Since it was my fault you died\nearly, You can decide happens for your next life.\n\n[A] Reincarnate as a regular villager in your next life.\n[B] Reincarnate as an Adventurer in your next life.\n",

            // Player chooses A to live as a villager.
            // PartOne [1]
            "You have chosen to live as a regular villager!" ,

            // Player chooses B to live as an Adventurer.
            // PartOne [2]
            "You have chosen to live as an adventurer!",

            // Story continues
            // PartOne [3]
            "\n\nGod: Very well, as a bonus for accidentally killing you early, you can have this\n legendary sword of legends. You can also choose one more gift and that is\n\n[A] You will be able to retain the memories of your past life or \n[B] 'Blessing of Language'\n",

            // Player chooses A to retain past memories.
            // PartOne [4]
            "You have chosen to retain memories of your past life! This knowledge will help you adapt in this strange new world.\n",

            // Player chooses B 'Blessing of Languages'.
            // PartOne [5]
            "You have chosen the 'Blessing of Language.' This will help you understand all languages.\n",

            // PartOne [6]
            "Now enjoy and explore this new world filled with adventure and magic! Your vision is engulfed by a white light...\n"
        };
        static string[] PartTwo = {
            
            //Description of the senario.
            // PartTwo [0]
            $"You’ve woken up alone in an empty hut. By your side is the legendary sword of legends. ‘So that really wasn’t a dream,’ you think to yourself.\nYou stumble out of the bed, your balance unstable. You will need to start moving around to get used to your new body.\n Your stomach begins growling. But first you will need food.\n\n[A] Start looking for food outside.\n[B] Look for food in the house.\n",

            // Player chooses to look for food outside.
            // PartTwo [1]
            "You have chosen to look for food outside.\nHealth +10\nEXP +10\n" ,

            // Player chooses to look for food inside.
            // PartTwo [2]
            "You have chosen to look for food inside.\nHealth +5\nEXP +5",

            // Story continues
            // PartTwo [3]
            "You found vegetables! Since your soul is not from this world, eating these vegetables will give you a special effect.\n\n[A] Eat vegetables raw.\n[B] Make soup out of it.\n",

            // Player chooses A to eat vegetables raw
            // PartTwo [4]
            "You have chosen to eat the vegetables raw! You have received the title ‘Practitioner of Raw Foodism’\nLevel: Beginner\nHealth + 50 points\nEXP + 10\nCongratulations! You leveled up!\n",

            // Player chooses B to make soup out of vegetables
            // PartTwo [5]
            "You have chosen to make soup out of the vegetables! You have received the title ‘Food Gourmet’ \nLevel: Beginner\nHealth + 20 points\nEXP + 15\nCongratulations! You leveled up!\n",

            // PartTwo [6]
            "You continue eating until you are full ..."
        };
        static string[] PartThree = {
            
            //Description of the senario.
            // PartThree [0]
            $"After eating, you've decided to explore the forest near your hut.\nYou just found a glowing flower and a large hammer on the ground!\nWhat will you do?\n\n[A] Pick up flower.\n[B] Pick up hammer.\n",

            // Player chooses sacred flower.
            // PartThree [1]
            "You have chosen the flower!" ,

            // Player chooses sturdy looking hammer.
            // PartThree [2]
            "You have chosen the hammer",

            // Story continues. Second NPC shows up.
            // PartThree [3]
            "A portal leading to the Fairy forest opened.\n",

            // Player chooses A to trade
            // PartThree [4]
            "Thank you kind stranger! This flower is part of our sacred tree, only one blooms every century. You've given us a blessing.\n",

            // Player chooses B to sell item
            // PartThree [5]
            "Great doing business with you! As a favor for selling your items to me, I will allow you to enter our lands\n",

            // PartThree [6]
            "You end up exploring the Fairy Forest till dawn. Sun begins to set on the horizon..."
        };
        

        // Branching Narrative ====================================
        static void Choice()
        {
            // For loop will keep the game moving until we run out of senarios
            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";               
                //
                switch (section)
                {
                    default:
                        EndGame();
                        break;
                    case 1:
                        // Part One

                        // Same pattern for each of the sections. 1) print the first part of the section.
                        WriteLine(PartOne[0]);

                        // 2) Read in player's choice (a or b).
                        ForegroundColor = ConsoleColor.Green;

                        Write("Enter your choice: ");
                        input = ReadLine();
                        input = input.ToLower();
                        ResetColor();

                        // 3) If a print the next part of the array, otherwise skip next and print 3rd.
                        if (input == "a")
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartOne[1]);
                            ResetColor();
                        }
                        else
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartOne[2]);
                            ResetColor();
                        }

                        // 4) Print next part of the section.
                        WriteLine(PartOne[3]);
                        ForegroundColor = ConsoleColor.Green;

                        Write("Enter your choice: ");
                        input = ReadLine();
                        input = input.ToLower();
                        ResetColor();

                        // 5) Again if a print next, otherwise skip ahead
                        if (input == "a")
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartOne[4]);
                            ResetColor();
                        }
                        else
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartOne[5]);
                            ResetColor();
                        }

                        //6) Print last piece of the section.
                        WriteLine(PartOne[6]);
                        Utility.Continue();
                        break;

                    case 2:
                        // Part One

                        // Same pattern for each of the sections. 1) print the first part of the section.
                        WriteLine(PartTwo[0]);

                        // 2) Read in player's choice (a or b).
                        ForegroundColor = ConsoleColor.Green;

                        Write("Enter your choice: ");
                        input = ReadLine();
                        input = input.ToLower();
                        ResetColor();

                        // 3) If a print the next part of the array, otherwise skip next and print 3rd.
                        if (input == "a")
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartTwo[1]);
                            ResetColor();
                        }
                        else
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartTwo[2]);
                            ResetColor();
                        }

                        // 4) Print next part of the section.
                        WriteLine(PartTwo[3]);
                        Inventory.Add("Vegetables");
                        ForegroundColor = ConsoleColor.Green;

                        Write("Enter your choice: ");
                        input = ReadLine();
                        input = input.ToLower();
                        ResetColor();

                        // 5) Again if a print next, otherwise skip ahead
                        if (input == "a")
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartTwo[4]);
                            ResetColor();
                        }
                        else
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartTwo[5]);
                            ResetColor();
                        }

                        //6) Print last piece of the section.
                        WriteLine(PartTwo[6]);
                        Utility.Continue();
                        break;

                    case 3:
                        // Part TWO

                        // Same pattern for each of the sections. 1) print the first part of the section.
                        WriteLine(PartThree[0]);

                        // 2) Read in player's choice (a or b).
                        ForegroundColor = ConsoleColor.Green;

                        Write("Enter your choice: ");
                        input = ReadLine();
                        input = input.ToLower();
                        ResetColor();

                        // 3) If a print the next part of the array, otherwise skip next and print 3rd.
                        if (input == "a")
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartThree[1]);
                            ResetColor();
                            Inventory.Add("sacredFlower");
                            // 4) Print next part of the section.
                            WriteLine(PartThree[3]);
                            NPC.ElanorGardner();
                            ASCII.Fairy();
                            ForegroundColor = ConsoleColor.Green;

                            Write("Enter your choice: ");
                            input = ReadLine();
                            input = input.ToLower();
                            ResetColor();
                        }
                        else
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartThree[2]);
                            ResetColor();
                            Inventory.Add("dwarvenhammer");
                        }

                        // 4) Print next part of the section.
                        WriteLine(PartThree[3]);
                        NPC.Vulca();
                        ASCII.Fairy();
                        ForegroundColor = ConsoleColor.Green;

                        Write("Enter your choice: ");
                        input = ReadLine();
                        input = input.ToLower();
                        ResetColor();


                        // 5) Again if a print next, otherwise skip ahead
                        if (input == "a")
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartThree[4]);
                            Write("Your job changed from Villager to Magician","cyan");
                            WriteLine("You: It was a pleasure trading the staff for it Elanor");
                            ResetColor();
                        }
                        else
                        {
                            ForegroundColor = ConsoleColor.Cyan;
                            WriteLine(PartThree[5]);
                            Write("Your job changed from Villager to Swordsman", "cyan");
                            WriteLine("\n\nYou: It was a pleasure trading the staff for it Vulcan");
                            ResetColor();
                        }

                        //6) Print last piece of the section.
                        WriteLine(PartThree[6]);
                        Utility.Continue();                       
                        break;                                     
                }      
            }
        }

        // Code from Programming is fun
        public static void EndGame()
        {
            //end of game text
            WriteLine("You have reached the end of the game.");
            WriteLine("Congratulations " + Player.CharacterName + "!");

            WriteLine(Player.CharacterName + " you found some items in your journey:");

            foreach (string item in Inventory)
            {
                WriteLine(item);
            }
        }
    }
}
