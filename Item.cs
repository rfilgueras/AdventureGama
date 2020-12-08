using System;
using static System.Console;

namespace AdventureGame
{
    public class Item 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemCost { get; set; }
        public ConsoleColor ItemColor { get; set; }

        public Item()
        {
            
        }

        public Item(string name, string description, int itemCost, ConsoleColor color = ConsoleColor.Green)
        {
            Name = name;
            Description = description;
            ItemCost = itemCost;
            ItemColor = color;
        }

        public string PrintItemInfo()
        {
            string ItemInfo = $"{Name}: {Description} {ItemCost} gold";
            WriteLine($"{ItemInfo}");
            return ItemInfo;
        }

        
    }
}
