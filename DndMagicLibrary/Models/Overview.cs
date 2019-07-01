using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndMagicLibrary.Models
{
    public class Overview
    {
        public List<string> ClassDescriptions { get; set; }
        public List<DndClass> Classes { get; set; }

        public List<DndClass> GetDndClasses()
        {
            List<DndClass> classes = new List<DndClass>
            {
                new DndClass { ClassName = "Bard", Description = "Whether scholar, skald, or scoundrel, a bard weaves magic through words and music to inspire allies, demoralize foes, manipulate minds, create illusions, and even heal wounds. The bard is a master of song, speech, and the magic they contain." },
                new DndClass { ClassName = "Cleric", Description = "Clerics are intermediaries between the mortal world and the distant planes of the gods. As varied as the gods they serve, clerics strive to embody the handiwork of their deities. No ordinary priest, a cleric is imbued with divine magic." },
                new DndClass { ClassName = "Druid", Description = "Whether calling on the elemental forces of nature or emulating the creatures of the animal world, druids are an embodiment of nature's resilience, cunning, and fury. They claim no mastery over nature, but see themselves as extensions of nature's indomitable will." },
                new DndClass { ClassName = "Paladin", Description = "Whether sworn before a god's altar and the witness of a priest, in a sacred glade before nature spirits and fey beings, or in a moment of desperation and grief with the dead as the only witness, a paladin's oath is a powerful bond." },
                new DndClass { ClassName = "Ranger", Description = "Far from the bustle of cities and towns, past the hedges that shelter the most distant farms from the terrors of the wild, amid the dense-packed trees of trackless forests and across wide and empty plains, rangers keep their unending watch." },
                new DndClass { ClassName = "Sorcerer", Description = "Sorcerers carry a magical birthright conferred upon them by an exotic bloodline, some otherworldly influence, or exposure to unknown cosmic forces. No one chooses sorcery; the power chooses the sorcerer." },
                new DndClass { ClassName = "Warlock", Description = "Warlocks are seekers of the knowledge that lies hidden in the fabric of the multiverse. Through pacts made with mysterious beings of supernatural power, warlocks unlock magical effects both subtle and spectacular." },
                new DndClass { ClassName = "Wizard", Description = "Wizards are supreme magic-users, defined and united as a class by the spells they cast. Drawing on the subtle weave of magic that permeates the cosmos, wizards cast spells of explosive fire, arcing lightning, subtle deception, brute-force mind control, and much more." }
            };

            return classes;
        }
    }

    
}