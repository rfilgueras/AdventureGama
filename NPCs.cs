using System;
using static System.Console;
namespace AdventureGame
{
    public class NPC
    {

        public string Name { get; set; }
        public string Dialogue { get; set; }

        public NPC()
        {

        }

        
        //  ===================  Start OF NPCs  ===========================
        // NPC of the Fairy forest
        public static void ElanorGardner()
        {
            WriteLine("Hello stranger, I am Elanor Gardner. I see that you have come upon an interesting item along the way.\nI would like to trade my magic staff for it. If you don't want to trade I can also buy it for 100 gold.\nWhat will you do?\n[A] Trade sacred flower for a magic staff. \n[B] Sell it for 100 Gold.\n\n");
        }

        public static void Vulca()
        {
            WriteLine("Hello stranger, I am Vulca. I see that you have come upon an interesting item along the way.\nI would like to trade my longsword for it. If you don't want to trade I can also buy it for 100 gold.\nWhat will you do?\n[A] Trade the hammer for a long sword. \n[B] Sell it for 100 Gold.\n\n");
        }
    }
}
