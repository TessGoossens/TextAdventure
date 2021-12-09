using DocumentFormat.OpenXml.Drawing;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;



namespace TextAdeventure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game.MakeGrid(); 
            Game.Command();
            BeginGame();
            StartGame();
            
        }

        private static void BeginGame()
        {
            Console.WriteLine();
            Console.WriteLine("De bedoeling van de game is om alle kristallen te verzamelen en de kroon compleet te maken");
            Console.WriteLine("Je begint in het midden van het speel veld");
            Console.WriteLine("Hetis niet mogelijk om het speelveld te verlaten");
            Console.WriteLine("veel sucsess");
            Console.WriteLine();
            Game.Kroongeven();
        }

        private static void StartGame()
        {
            var keeprunning = true;
            var Userimput = "";
            while (keeprunning)
            {
                Console.WriteLine(Game.DescribeLocation());
                Console.WriteLine("voer je actie in");
                Console.WriteLine();
                Userimput = Console.ReadLine();
                if (Userimput == "stop")
                {
                    keeprunning = false;
                }
                else if (Userimput == "go south")
                {
                    Game.GoSouth();
                }
                else if (Userimput == "go north")
                { 
                    Game.GoNorth();
                }
                else if (Userimput == "go east")
                {
                    Game.GoEast();
                }
                else if (Userimput == "go west")
                {
                    Game.GoWest();
                }
                else if (Userimput == "pick up")
                {
                    Game.PickUp();
                }
                else if (Userimput == "drop item")
                {
                    Game.DropItem();
                }
                else if (Userimput == "use item")
                {
                    Game.UseItem();
                }
                else if (Userimput == "kroon compleet maken")
                {
                    Game.KroonCompleet();
                }
                else if (Userimput == "commands")
                {
                    Game.Command();
                }
                else if (Userimput == "look west")
                {
                    Game.LookWest();
                }
                else if (Userimput == "look north")
                {
                    Game.LookWest();
                }
                else if (Userimput == "look east")
                {
                    Game.LookWest();
                }
                else if (Userimput == "look south")
                {
                    Game.LookWest();
                }
                else if (Userimput == "inventory")
                {
                    Game.Inventory();
                }
                else if (Userimput == "save")
                {
                    Game.Save();
                }
                else if (Userimput == "load")
                {
                    Game.Load();
                }
                else
                {
                    Console.WriteLine("wrong input");
                }
            }
        }
    }
}
