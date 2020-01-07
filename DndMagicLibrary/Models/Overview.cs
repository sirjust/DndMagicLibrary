using DndMagicLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndMagicLibrary.Models
{
    public class Overview
    {
        public List<DndClass> Classes { get; set; }

        public List<DndClass> GetDndClasses()
        {
            List<DndClass> classes = new List<DndClass>
            {
                new DndClass("Bard", Descriptions.DescriptionsDictionary["Bard"], 2, 1),
                new DndClass("Cleric", Descriptions.DescriptionsDictionary["Cleric"], 3, 2),
                new DndClass("Druid", Descriptions.DescriptionsDictionary["Druid"], 4, 3),
                new DndClass("Paladin", Descriptions.DescriptionsDictionary["Paladin"], 7, 4),
                new DndClass("Ranger", Descriptions.DescriptionsDictionary["Ranger"], 8, 5),
                new DndClass("Sorcerer", Descriptions.DescriptionsDictionary["Sorcerer"], 10, 6),
                new DndClass("Warlock", Descriptions.DescriptionsDictionary["Warlock"], 11, 7),
                new DndClass("Wizard", Descriptions.DescriptionsDictionary["Wizard"], 12, 8)
            };

            return classes;
        }
    }
}