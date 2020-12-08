using System;
using static System.Console;
namespace AdventureGame
{
    public class ASCII
    {
        public ASCII()
        {

        }

        public static void WelcomeAscii()
        {
            //ASCII Design
            string title = @"
 ___       __   ________  ________  ___       ________          ________  ________  ________   ________  ________  ________  _______      
|\  \     |\  \|\   __  \|\   __  \|\  \     |\   ___ \        |\   __  \|\   __  \|\   ____\ |\   ____\|\   __  \|\   ____\|\  ___ \     
\ \  \    \ \  \ \  \|\  \ \  \|\  \ \  \    \ \  \_|\ \       \ \  \|\  \ \  \|\  \ \  \___|_\ \  \___|\ \  \|\  \ \  \___|\ \   __/|    
 \ \  \  __\ \  \ \  \\\  \ \   _  _\ \  \    \ \  \ \\ \       \ \   ____\ \   __  \ \_____  \\ \_____  \ \   __  \ \  \  __\ \  \_|/__  
  \ \  \|\__\_\  \ \  \\\  \ \  \\  \\ \  \____\ \  \_\\ \       \ \  \___|\ \  \ \  \|____|\  \\|____|\  \ \  \ \  \ \  \|\  \ \  \_|\ \ 
   \ \____________\ \_______\ \__\\ _\\ \_______\ \_______\       \ \__\    \ \__\ \__\____\_\  \ ____\_\  \ \__\ \__\ \_______\ \_______\
    \|____________|\|_______|\|__|\|__|\|_______|\|_______|        \|__|     \|__|\|__|\_________\\_________\|__|\|__|\|_______|\|_______|
                                                                                      \|_________\|_________|                                                                                                                                                                                                                                                                                                                                                                                      
";
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine(title);
            ResetColor();
        }

        public static void Portal()
        {
            string portal = @"

             XXXXXX     XXXXXXXXX
          XXX      XXXXXXXXXXXXX XXXX
       XXX        XXXXXXXX     XXXX XXX
      XXX     XXXX        XXXXXX  XXX XXX
    XXXX    XX   XXXXXXXXX      XX   X  XXX
   X  X  XXX    XX        XXXX   XX   X  XX
 XX  X  XX   XXXX    XXXXX    XX   X  X   XX
XX  XX  X   X     XXX     XXX   X  XX  X   XX
X  XX   X XX    XXX         XX  X   X  X   XX
X XX   XX X    XX            XX X   X  X    XX
X X    X X    X              XXXX   X  X    X X
X X    X X   XX              X X    XX X     XX
XX     X  X  X               X X     X X     XX
X X    X  X  XX            XXX X    X  X    X X
X X    X  XX  XX XXXX   XXXX   X    X XX    X X
 X X   X   XX  XX   XXXX     XX    XXXX   XX
 X  X   X    XX  XXXX      XXX    X XX  XXX  X
 XX XX  XX    X X    XXXXXX    XXX XX  XX   XX
  X   XX  XX     XXX       XXXX XXXX XX    X
  XXX  XXX  XXXXXX  XXXXXXX   XXX  XX    XX
     XX  XX       XXXXXXXXXXXXX  XXX    X
       XXX XXXXXX           XXXXXX   XXX
         XX      X XXXXXXXXX        
                    
";
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(portal);
            ResetColor();
        }

        public static void Fairy()
        {
            string fairy = @"
               XX
              XXX
            XXXXX        XXXXX
           XXXXXXX     XX  X
         XXXXXXXXXXXXXX   X
        XXXXXXXXXXXX     X
      X XXXXXXXXX       X
     XxxxxxxXX          X
    / \xxxxxX          X
   /   \xxX    XXXX   XX
  /     \X   XX  XX   XX
 /_______\  X    X   XX
 / _   _  \ X       XX
| |_| |_|  |XX     XX
|   ___(  /XX XXXX
 \_______/
";
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(fairy);
            ResetColor();
        }
      
    }
}
