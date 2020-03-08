using DndMagicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndMagicLibrary.Data
{
    public static class SpellsKnown
    {
        public static List<List<Spell>> GetSpells(string dndClass)
        {
            switch (dndClass)
            {
                case "Bard":
                    {
                        return new List<List<Spell>>
                            {
                                new List<Spell>
                                {
                                    new Spell{Name= "Dancing Lights"},
                                    new Spell{Name= "Light"},
                                    new Spell{Name= "Mage Hand"},
                                    new Spell{Name= "Mending"},
                                    new Spell{Name= "Message"},
                                    new Spell{Name= "Minor Illusion"},
                                    new Spell{Name= "Prestidigitation"},
                                    new Spell{Name= "True Strike"},
                                    new Spell{Name= "Vicious Mockery"}
                                },
                                new List<Spell>
                                {
                                    new Spell{Name= "Animal Friendship"},
                                    new Spell{Name= "Bane"},
                                    new Spell{Name= "Charm Person"},
                                    new Spell{Name= "Comprehend Languages"},
                                    new Spell{Name= "Cure Wounds"},
                                    new Spell{Name= "Detect Magic"},
                                    new Spell{Name= "Disguise Self"},
                                    new Spell{Name= "Faerie Fire"},
                                    new Spell{Name= "Feather Fall"},
                                    new Spell{Name= "Healing Word"},
                                    new Spell{Name= "Heroism"},
                                    new Spell{Name= "Hideous Laughter"},
                                    new Spell{Name= "Identify"},
                                    new Spell{Name= "Illusory Script"},
                                    new Spell{Name= "Longstrider"},
                                    new Spell{Name= "Silent Image"},
                                    new Spell{Name= "Sleep"},
                                    new Spell{Name= "Speak with Animals"},
                                    new Spell{Name= "Thunderwave"},
                                    new Spell{Name= "Unseen Servant"}
                                }
                            };
                    }
                default:
                    return new List<List<Spell>>();
            }

        }
    }
}