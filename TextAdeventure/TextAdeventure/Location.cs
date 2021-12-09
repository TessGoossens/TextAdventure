using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdeventure
{
    class Location
    {
        public string Name { get; set; }// get was changed to gets
        public string Type { get; set; }
        public string Weather { get; set; }
        public int RowNumber { get; set; }
        public int ColumNumber { get; set; }
        public string Items { get; set; }
        public string Access { get; set; }
        

        public Location(string name, string type, string weather, string access, string items)
        {
            Weather = weather;
            Type = type;
            Name = name;
            Access = access;
            Items = items;
        }
        
        public string Describe()
        {
            // TODO Maak een omschrijving van de locatie mbv Name, Weather en Area
            string description = "je bet nu hier = " + Name + "        op het moment is het weer = " + Weather + "        op deze locatie ligt = " + Items;
            return description;
        }

    }
}

