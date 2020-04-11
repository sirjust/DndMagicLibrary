using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DndMagicLibrary.Data
{
    public class ClassSpellLists
    {
        public Dictionary<int, IEnumerable<string>> BardSpellNames { get; set; }
        public Dictionary<int, IEnumerable<string>> ClericSpellNames { get; set; }
        public Dictionary<int, IEnumerable<string>> DruidSpellNames { get; set; }
        public Dictionary<int, IEnumerable<string>> PaladinSpellNames { get; set; }
        public Dictionary<int, IEnumerable<string>> RangerSpellNames { get; set; }
        public Dictionary<int, IEnumerable<string>> SorcererSpellNames { get; set; }
        public Dictionary<int, IEnumerable<string>> WarlockSpellNames { get; set; }
        public Dictionary<int, IEnumerable<string>> WizardSpellNames { get; set; }

        public Dictionary<int, IEnumerable<string>> GetBardSpells()
        {
            return new Dictionary<int, IEnumerable<string>>
            {
                {
                    0,
                    new List<string>
                    {
                        "Dancing Lights",
                        "Light",
                        "Mage Hand",
                        "Mending",
                        "Message",
                        "Minor Illusion",
                        "Prestidigitation",
                        "True Strike",
                        "Vicious Mockery"
                    }
                },
                {
                    1,
                    new List<string>
                    {
                        "Animal Friendship",
                        "Bane",
                        "Charm Person",
                        "Comprehend Languages",
                        "Cure Wounds",
                        "Detect Magic",
                        "Disguise Self",
                        "Faerie Fire",
                        "Feather Fall",
                        "Healing Word",
                        "Heroism",
                        "Hideous Laughter",
                        "Identify",
                        "Illusory Script",
                        "Longstrider",
                        "Silent Image",
                        "Sleep",
                        "Speak with Animals",
                        "Thunderwave",
                        "Unseen Servant"
                    }
                },
                {
                    2,
                    new List<string>
                    {
                        "Animal Messenger",
                        "Blindness/Deafness",
                        "Calm Emotions",
                        "Cloud of Daggers",
                        "Crown of Madness",
                        "Detect Thoughts",
                        "Enhance Ability",
                        "Enthrall",
                        "Heat Metal",
                        "Hold Person",
                        "Invisibility",
                        "Knock",
                        "Lesser Restoration",
                        "Locate Animals or Plants",
                        "Locate Object",
                        "Magic Mouth",
                        "Phantasmal Force",
                        "Pyrotechnics",
                        "See Invisibility",
                        "Shatter",
                        "Silence",
                        "Skywrite",
                        "Suggestion",
                        "Warding Wind",
                        "Zone of Truth"
                    } 
                },
                    {
                    3,
                    new List<string>
                    {
                        "Bestow Curse",
                        "Clairvoyance",
                        "Dispel Magic",
                        "Enemies Abound",
                        "Fear",
                        "Feign Death",
                        "Glyph of Warding",
                        "Hypnotic Pattern",
                        "Leomund's Tiny Hut",
                        "Major Image",
                        "Nondetection",
                        "Plant Growth",
                        "Sending",
                        "Speak with Dead",
                        "Speak with Plants",
                        "Stinking Cloud",
                        "Summon Fey Spirit (UA)",
                        "Tongues",
                    }
                },
                {
                    4,
                    new List<string>
                    {
                        "Compulsion",
                        "Confusion",
                        "Dimension Door",
                        "Freedom of Movement",
                        "Greater Invisibility",
                        "Hallucinatory Terrain",
                        "Locate Creature",
                        "Polymorph"
                    }
                },
                {
                    5,
                    new List<string>
                    {
                        "Animate Objects",
                        "Awaken",
                        "Dominate Person",
                        "Dream",
                        "Geas",
                        "Greater Restoration",
                        "Hold Monster",
                        "Legend Lore",
                        "Mass Cure Wounds",
                        "Mislead",
                        "Modify Memory",
                        "Planar Binding",
                        "Raise Dead",
                        "Scrying",
                        "Seeming",
                        "Teleportation Circle"
                    }
                },
                {
                    6,
                    new List<string>
                    {
                        "Eyebite",
                        "Find the Path",
                        "Guards and Wards",
                        "Mass Suggestion",
                        "Otto's Irresistible Dance",
                        "Programmed Illusion",
                        "True Seeing"
                    }
                },
                {
                    7,
                    new List<string>
                    {
                        "Etherealness",
                        "Forcecage",
                        "Mirage Arcane",
                        "Mordenkainen's Magnificent Mansion",
                        "Mordenkainen's Sword",
                        "Project Image",
                        "Regenerate",
                        "Resurrection",
                        "Symbol",
                        "Teleport"
                    }
                },
                {
                    8,
                    new List<string>
                    {
                        "Dominate Monster",
                        "Feeblemind",
                        "Glibness",
                        "Mind Blank",
                        "Power Word: Stun"
                    }
                },
                {
                    9,
                    new List<string>
                    {
                        "Foresight",
                        "Power Word: Heal",
                        "Power Word: Kill",
                        "True Polymorph"
                    }
                }
            };       
        }

        public Dictionary<int, IEnumerable<string>> GetClericSpells()

        {
            return new Dictionary<int, IEnumerable<string>>
            {
                {
                    0,
                    new List<string>
                    {
                        "Guidance",
                        "Word of Radiance",
                        "Light",
                        "Mending",
                        "Resistance",
                        "Sacred Flame",
                        "Spare the Dying",
                        "Thaumaturgy",
                        "Toll the Dead",
                        "Virtue"
                    }
                },
                {
                    1,
                    new List<string>
                    {
                        "Bane",
                        "Bless",
                        "Command",
                        "Create or Destroy Water",
                        "Cure Wounds",
                        "Detect Evil and Good",
                        "Detect Magic",
                        "Detect Poison and Disease",
                        "Divine Favor",
                        "Guiding Bolt",
                        "Guiding Hand",
                        "Healing Word",
                        "Inflict Wounds",
                        "Protection from Evil and Good",
                        "Purify Food and Drink",
                        "Sanctuary",
                        "Shield of Faith"
                    }
                },
                {
                    2,
                    new List<string>
                    {
                        "Aid",
                        "Augury",
                        "Blindness/Deafness",
                        "Calm Emotions",
                        "Continual Flame",
                        "Enhance Ability",
                        "Find Traps",
                        "Gentle Repose",
                        "Hold Person",
                        "Lesser Restoration",
                        "Locate Object",
                        "Prayer of Healing",
                        "Protection from Poison",
                        "Silence",
                        "Spiritual Weapon",
                        "Warding Bond",
                        "Zone of Truth"
                    }
                },
                    {
                    3,
                    new List<string>
                    {
                        "Animate Dead",
                        "Beacon of Hope",
                        "Bestow Curse",
                        "Clairvoyance",
                        "Create Food and Water",
                        "Daylight",
                        "Dispel Magic",
                        "Feign Death",
                        "Glyph of Warding",
                        "Magic Circle",
                        "Mass Healing Word",
                        "Meld into Stone",
                        "Protection from Energy",
                        "Remove Curse",
                        "Revivify",
                        "Sending",
                        "Speak with Dead",
                        "Spirit Guardians",
                        "Spirit Shroud (UA)",
                        "Tongues",
                        "Water Walk"
                    }
                },
                {
                    4,
                    new List<string>
                    {
                        "Banishment",
                        "Control Water",
                        "Death Ward",
                        "Divination",
                        "Freedom of Movement",
                        "Guardian of Faith",
                        "Locate Creature",
                        "Stone Shape"
                    }
                },
                {
                    5,
                    new List<string>
                    {
                        "Commune",
                        "Contagion",
                        "Dispel Evil and Good",
                        "Flame Strike",
                        "Geas",
                        "Greater Restoration",
                        "Hallow",
                        "Insect Plague",
                        "Legend Lore",
                        "Mass Cure Wounds",
                        "Planar Binding",
                        "Raise Dead",
                        "Scrying"
                    }
                },
                {
                    6,
                    new List<string>
                    {
                        "Blade Barrier",
                        "Create Undead",
                        "Find the Path",
                        "Forbiddance",
                        "Harm",
                        "Heal",
                        "Heroes' Feast",
                        "Planar Ally",
                        "True Seeing",
                        "Word of Recall"
                    }
                },
                {
                    7,
                    new List<string>
                    {
                        "Conjure Celestial",
                        "Divine Word",
                        "Etherealness",
                        "Fire Storm",
                        "Plane Shift",
                        "Regenerate",
                        "Resurrection",
                        "Symbol"
                    }
                },
                {
                    8,
                    new List<string>
                    {
                        "Antimagic Field",
                        "Control Weather",
                        "Earthquake",
                        "Holy Aura"
                    }
                },
                {
                    9,
                    new List<string>
                    {
                        "Astral Projection",
                        "Gate",
                        "Mass Heal",
                        "True Resurrection"
                    }
                }
            };
        }

        public Dictionary<int, IEnumerable<string>> GetDruidSpells()
        {
            return null;
        }

        public Dictionary<int, IEnumerable<string>> GetPaladinSpells()
        {
            return null;
        }

        public Dictionary<int, IEnumerable<string>> GetRangerSpells()
        {
            return null;
        }

        public Dictionary<int, IEnumerable<string>> GetSorcererSpells()
        {
            return null;
        }

        public Dictionary<int, IEnumerable<string>> GetWarlockSpells()
        {
            return null;
        }
    }                
}                    