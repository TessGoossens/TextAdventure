using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdeventure
{
    class Game
    {
        static int posx = 6;
        static int posy = 6;

        static Location[,] GridMap = new Location[14, 12];
        static List<string> playerItems = new List<string>();
        static List<string> kroon = new List<string>();
       



        public static void MakeGrid() // string grid was addet  inside ()
        {
            // Lees alle regels in van grid.txt
            string[] lines = File.ReadAllLines("C:/Users/Eigenaar/OneDrive/Project Folder/leerjaar 2/TextAdeventure/TextAdeventure/grid.txt");
            // Maak voor elke regel een nieuwe Location aan
            int i = 0;

            for (var X = 0; X < 14; X++)
            {
                for (var Y = 0; Y < 12; Y++)
                {
                    var line = lines[i++];
                    var parts = line.Split(',');
                    var name = parts[0];
                    var type = parts[1];
                    var weather = parts[2];
                    var Access = parts[3].Trim();
                    var Items = parts[4].Trim();

                    var location = new Location(name, type, weather, Access, Items);
                    GridMap[X, Y] = location;
                }
            }
        }

        public static void Inventory()
        {
            foreach (var item in playerItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
        }

        internal static void PickUp()
        {
            if (GridMap[posx, posy].Items == " ")
            {
                Console.WriteLine("er ligt hier niets");
            }
            if (GridMap[posx, posy].Items != " ")
            {
                Console.WriteLine("Je hebt " + GridMap[posx, posy].Items + " opgepakt");
                playerItems.Add(GridMap[posx, posy].Items);
                GridMap[posx, posy].Items = " ";
                Console.WriteLine(" ");
            }
        }

        internal static void DropItem()
        {
            Console.WriteLine("wat item wil je laten vallen?");
            var Item = Console.ReadLine();
            if (Item == "kroon")
            {
                Console.WriteLine("Je kan de kroon niet uit je inventory halen");
            }
            if (GridMap[posx, posy].Items != " ")
            {
                Console.WriteLine(" je kan hier niks neerleggen");
            }
            if (GridMap[posx, posy].Items == " ")
            {
                playerItems.Remove(Item);
                GridMap[posx, posy].Items = Item; ;
            }
        }

        internal static void KroonCompleet()
        {
            Int32 length = kroon.Count;
            if (length == 4)
            {
                Console.WriteLine("de kroon is compleet het spel is afgelopen");
                Console.WriteLine("om het spel te stoppen type stop");
            }
            else
            {
                Console.WriteLine("Je hebt nog niet alle cristallen verzameld");
            }
        }

        internal static void UseItem()
        {
            Console.WriteLine("welk item wil je gebruiken?");
            var use = Console.ReadLine();


            if (use == "apple")
            {
                Console.WriteLine("Je hebt de appel gegeten hij was erg zoet");
                playerItems.Remove(use);
            }
            else if (use == "blue cristal")
            {
                Console.WriteLine("je hebt het kristal toegevoegd aan de kroon");
                playerItems.Remove(use);
                kroon.Add(use);
            }
            else if (use == "pink cristal")
            {
                Console.WriteLine("je hebt het kristal toegevoegd aan de kroon");
                playerItems.Remove(use);
                kroon.Add(use);
            }
            else if (use == "green cristal")
            {
                Console.WriteLine("je hebt het kristal toegevoegd aan de kroon");
                playerItems.Remove(use);
                kroon.Add(use);
            }
            else if (use == "purple cristal")
            {
                Console.WriteLine("je hebt het kristal toegevoegd aan de kroon");
                playerItems.Remove(use);
                kroon.Add(use);
            }
            else
            {
                Console.WriteLine("Je hebt dit object niet");
            }
        }

        internal static void GoSouth()
        {
            posx++;

            if (posx > 13)
            {
                Console.WriteLine("Het is niet mogelijk om de stad te verlaten");
                posx = 13;
            }
            if (GridMap[posx, posy].Access == "n")
            {
                Console.WriteLine("je mag hier niet heen");
                posx--;
            }
        }

        internal static void GoNorth()
        {
            posx--;

            if (posx < 0)
            {
                Console.WriteLine("Het is niet mogelijk om de stad te verlaten");
                posx = 0;
            }
            if (GridMap[posx, posy].Access == "n")
            {
                Console.WriteLine("je mag hier niet heen");
                posx++;
            }
        }

        internal static void GoEast()
        {
            posy++;

            if (posy > 11)
            {
                Console.WriteLine("Het is niet mogelijk om de stad te verlaten");
                posy = 11;
            }
            if (GridMap[posx, posy].Access == "n")
            {
                Console.WriteLine("je mag hier niet heen");
                posy--;
            }
        }

        internal static void GoWest()
        {
            posy--;

            if (posy < 0)
            {
                Console.WriteLine("Het is niet mogelijk om de stad te verlaten");
                posy = 0;
            }
            if (GridMap[posx, posy].Access == "n")
            {
                Console.WriteLine("je mag hier niet heen");
                posy++;
            }
        }

        public static string DescribeLocation()
        {
            return GridMap[posx, posy].Describe();
        }

        internal static void LookNorth()
        {
            posx--;

            if (posx < 0)
            {
                Console.WriteLine("dit is de rand van de map");
                posx++;
            }
            else
            {
                if (GridMap[posx, posy].Access == "n")
                {
                    Console.WriteLine("hier staat een huis");
                    posx++;
                }
                else
                {
                    Console.WriteLine(GridMap[posx, posy].Describe());
                    posx++;
                }
            }
        }

        internal static void LookSouth()
        {
            posy++;

            if (posy > 13)
            {
                Console.WriteLine("dit is de rand van de map");
                posy--;
            }
            else
            {
                if (GridMap[posx, posy].Access == "n")
                {
                    Console.WriteLine("hier staat een huis");
                    posy--;
                }
                else
                {
                    Console.WriteLine(GridMap[posx, posy].Describe());
                    posy--;
                }
            }
        }

        internal static void LookEast()
        {
            posx++;

            if (posx > 11)
            {
                Console.WriteLine("dit is de rand van de map");
                posx--;
            }
            else
            {
                if (GridMap[posx, posy].Access == "n")
                {
                    Console.WriteLine("hier staat een huis");
                    posx--;
                }
                else
                {
                    Console.WriteLine(GridMap[posx, posy].Describe());
                    posx--;
                }
            }
        }

        internal static void LookWest()
        {
            posx--;

            if (posx < 0)
            {
                Console.WriteLine("dit is de rand van de map");
                posx++;
            }
            else
            {
                if (GridMap[posx, posy].Access == "n")
                {
                    Console.WriteLine("hier staat een huis");
                    posx++;
                }
                else
                {
                    Console.WriteLine(GridMap[posx, posy].Describe());
                    posx++;
                }
            }
        }

        internal static void Command()
        {
            Console.WriteLine();
            Console.WriteLine("Dit zijn de commands die je kan gebruiken");
            Console.WriteLine();
            Console.WriteLine("stop, go north, go south, go west, go east, pick up, drop item, use item, inventory");
            Console.WriteLine("look north, look south, look west,  look east, commands, kroon compleet maken, save, load");
            Console.WriteLine();
        }

        internal static void Kroongeven()
        {
            playerItems.Add("kroon");
        }
     
        internal static void Save()
        {
        
            Console.Write("hat woordt de save naam : ");

            var IngevuldeNaam = Console.ReadLine();
            var Posx = posx;
            var Posy = posy;


            SaveLoad.x = Posx;
            SaveLoad.y = Posy;

            SaveLoad.Save(IngevuldeNaam);
        }

        internal static void Load()
        {
            SaveLoad.Load("C:/Users/Eigenaar/OneDrive/Project Folder/leerjaar 2/TextAdeventure/TextAdeventure/SavedData.txt");
            posx = SaveLoad.x;
            posy = SaveLoad.y;
        }
    }
}