/*   [World Passage - Adventure Game]
 *   Rhone Filgueras, September 14, 2020
 *   
 *   This work is a derivative of
 *   "C# Adventure Game" by http://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_05_classes_objects/
 *   
 *   ASCII Design generated from
 *   http://patorjk.com/software/taag/#p=testall&f=Graffiti&t=World%20Passage
 *   Original ASCII art made in
 *   http://asciiflow.com/
 *   
 *   Utility code for changing the text color
 *   https://gist.github.com/janellbaxter/5608c0ac75cd227011596f7988648a32#file-pif-utility-cs
*/
using System;
using System.Collections.Generic;

namespace AdventureGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game.StartGame();            

            //  ===================  Start OF ITEMS  ===========================
            // Items that the player will already have in their inventory.
            Item woodenShield = new Item
                (
                "Wooden Sheild",
                "A piece of personal armour held in the hand, which may or may not be strapped to the wrist or forearm.\n" +
                "This shield cannot withstand magic attacks. Value in Gold:",
                15
                );

            Item shortSword = new Item
                (
                "Short Sword",
                "A light piercing melee weapon. Value in Gold:",
                25
                );

            // Items that the player will be able to pick up. 
            Item sacredFlower = new Item
                (
                "Sacred Flower",
                "A flower surrounded by a faint golden glow. It's petals can be used for medicine.\n" +
                "This flower valued by the fairies of the Ligurian Forest. Value in Gold:",
                500
                );
            Item dwarvenHammer = new Item
                (
                "Large Hammer",
                "Is a 200 cm latex hammer designed to be safer and easier to wield in combat.\n" +
                "This hammer is usually only found in Nidavellir, The Realm of Dawrves. Value in Gold:\n",
                300
                );

            // Items that the player will get if they agree to trade.
            Item magicStaff = new Item
                (
                "Magic Staff",
                "5ft of the wood crafted from the trees in the Ligurian forest.\n" +
                "It is imbued with magic from the faries\nYou will be able to cast magic with this staff. Value in Gold:",
                250
                );

            Item longSword = new Item
                (
                "Long Sword",
                "A sword with a cruciform hilt for two-handed use. It 27 inch straigt double-edge blade and weighs 5lb. Value in Gold:",
                350
                );


            //  ===================  Start OF LOCATIONS  ===========================            
             Location startingVillage = new Location
                 (
                 "Leone Village",
                 "The hometown of the original owner's body.\nThis town is known for nurturing the best adventurers.",
                 // Items in player inventory.           
                 new List<Item> { woodenShield },
                 // Required items for next location.
                 new List<Item> { }
                 );       


             Location humanCapital = new Location
                 (
                 "Kingdon of Jabril",
                 "The capital of the human nations. This is where players can trade and sell their items, and take new quests.",
                 // Items in player inventory.
                 new List<Item> { woodenShield },
                 // Required items for next location.
                 new List<Item> { }
                 );

             Location ligurianForest = new Location
                 (
                 "Ligurian Forest",
                 "Also kown as the Fairy Forest, this forest is dwealing place of all magical winged creatures",
                 new List<Item> { woodenShield, shortSword },
                 new List<Item> { sacredFlower }
                 );

             Location dwarfRealm = new Location
                 (
                 "Nidavellir",
                 "Also known as the Realm of Dwarves.\nOnly players deemed worthy by the dwarves can recieve an item from the dwarves.",
                 new List<Item> { woodenShield, shortSword },
                 new List<Item> { dwarvenHammer }
                 );            
        }
    }
}
