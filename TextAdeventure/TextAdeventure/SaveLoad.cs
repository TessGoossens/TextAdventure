using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


namespace TextAdeventure
{
    
    static class SaveLoad
    {
        static public int x { get; set; }
        static public int y { get; set; }


        public static void Save(string fileName)
        {
            string data = x + "," + y;

            // tekstbestand met de naam fileName, inhoud is data 
            StreamWriter File = new StreamWriter("C:/Users/Eigenaar/OneDrive/Project Folder/leerjaar 2/TextAdeventure/TextAdeventure/SavedData.txt");
            File.Write("data");
            File.Close();
        }

        public static void Load(string fileName) // bool new was added to Load(string fileName)
        {
            string data = "";

            // tekstbestandje lezen
            string[] lines = File.ReadAllLines("C:/Users/Eigenaar/OneDrive/Project Folder/leerjaar 2/TextAdeventure/TextAdeventure/SavedData.txt");

            var parts = data.Split(',');

            x = int.Parse(parts[0]);
            y = int.Parse(parts[1]);
        }
    }
}


