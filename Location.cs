using System;
using System.Collections.Generic;
using static System.Console;

namespace AdventureGame
{
    public class Location
    {
        public Location()
        {
        }

        // Code from group assignment week 7.
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        public ConsoleColor LocationColor { get; set; }
        public List<Item> RequiredItems { get; set; }

        // Code from group assignment week 7.
        //Two constructors. Overloaded so that we could display two ways of initializing objects.
        public Location(string name, string description, List<Item> items, List<Item> requiredItems, ConsoleColor color = ConsoleColor.Cyan)
        {
            Name = name;
            Description = description;
            Items = items;
            RequiredItems = requiredItems;
            LocationColor = color;
        }

        // Code from group assignment week 7.
        //A simple method that sends out a simple string. Displays the name and description.
        public string PrintLocationInfo()
        {
            string LocationInfo = Name + ": " + Description;
            return LocationInfo;
        }
     
    }
}
