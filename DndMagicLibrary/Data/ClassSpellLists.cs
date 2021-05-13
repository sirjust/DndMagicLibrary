using System.Collections.Generic;

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
            return new Dictionary<int, IEnumerable<string>>
            {
                {
                    0,
                    new List<string>
                    {
                        "Druidcraft",
                        "Guidance",
                        "Mending",
                        "Poison Spray",
                        "Produce Flame",
                        "Resistance",
                        "Shillelagh"
                    }
                },
                {
                    1,
                    new List<string>
                    {
                        "Animal Friendship",
                        "Charm Person",
                        "Create or Destroy Water",
                        "Cure Wounds",
                        "Detect Magic",
                        "Detect Poison and Disease",
                        "Entangle",
                        "Faerie Fire",
                        "Fog Cloud",
                        "Goodberry",
                        "Healing Word",
                        "Jump",
                        "Longstrider",
                        "Purify Food and Drink",
                        "Speak with Animals",
                        "Thunderwave"
                    }
                },
                {
                    2,
                    new List<string>
                    {
                        "Animal Messenger",
                        "Barkskin",
                        "Darkvision",
                        "Enhance Ability",
                        "Find Traps",
                        "Flame Blade",
                        "Flaming Sphere",
                        "Gust of Wind",
                        "Heat Metal",
                        "Hold Person",
                        "Lesser Restoration",
                        "Locate Animals or Plants",
                        "Locate Object",
                        "Moonbeam",
                        "Pass without Trace",
                        "Protection from Poison",
                        "Spike Growth"
                    }
                },
                {
                    3,
                    new List<string>
                    {
                        "Call Lightning",
                        "Conjure Animals",
                        "Daylight",
                        "Dispel Magic",
                        "Meld into Stone",
                        "Plant Growth",
                        "Protection from Energy",
                        "Sleet Storm",
                        "Speak with Plants",
                        "Water Breathing",
                        "Water Walk",
                        "Wind Wall"
                    }
                },
                {
                    4,
                    new List<string>
                    {
                        "Blight",
                        "Confusion",
                        "Conjure Minor Elementals",
                        "Conjure Woodland Beings",
                        "Control Water",
                        "Dominate Beast",
                        "Freedom of Movement",
                        "Giant Insect",
                        "Hallucinatory Terrain",
                        "Ice Storm",
                        "Locate Creature",
                        "Polymorph",
                        "Stone Shape",
                        "Stoneskin",
                        "Wall of Fire"
                    }
                },
                {
                    5,
                    new List<string>
                    {
                        "Antilife Shell",
                        "Awaken",
                        "Commune with Nature",
                        "Conjure Elemental",
                        "Contagion",
                        "Geas",
                        "Greater Restoration",
                        "Insect Plague",
                        "Mass Cure Wounds",
                        "Planar Binding",
                        "Reincarnate",
                        "Scrying",
                        "Tree Stride",
                        "Wall of Stone"
                    }
                },
                {
                    6,
                    new List<string>
                    {
                        "Conjure Fey",
                        "Find the Path",
                        "Heal",
                        "Heroes' Feast",
                        "Move Earth",
                        "Sunbeam",
                        "Transport via Plants",
                        "Wall of Thorns",
                        "Wind Walk"
                    }
                },
                {
                    7,
                    new List<string>
                    {
                        "Fire Storm",
                        "Mirage Arcane",
                        "Plane Shift",
                        "Regenerate",
                        "Reverse Gravity"
                    }
                },
                {
                    8,
                    new List<string>
                    {
                        "Animal Shapes",
                        "Antipathy/Sympathy",
                        "Control Weather",
                        "Earthquake",
                        "Feeblemind",
                        "Sunburst"
                    }
                },
                {
                    9,
                    new List<string>
                    {
                        "Foresight",
                        "Shapechange",
                        "Storm of Vengeance",
                        "True Resurrection"
                    }
                },
            };
        }

        public Dictionary<int, IEnumerable<string>> GetPaladinSpells()
        {
            return new Dictionary<int, IEnumerable<string>>
            {
                {
                    1, new List<string>
                    {
                        "Bless",
                        "Command",
                        "Cure Wounds",
                        "Detect Evil and Good",
                        "Detect Magic",
                        "Detect Poison and Disease",
                        "Divine Favor",
                        "Heroism",
                        "Protection from Evil and Good",
                        "Purify Food and Drink",
                        "Shield of Faith"
                    }
                },
                {
                    2, new List<string>
                    {
                        "Aid",
                        "Branding Smite",
                        "Find Steed",
                        "Lesser Restoration",
                        "Locate Object",
                        "Magic Weapon",
                        "Protection from Poison",
                        "Zone of Truth"
                    }
                },
                {
                    3, new List<string>
                    {
                        "Create Food and Water",
                        "Daylight",
                        "Dispel Magic",
                        "Magic Circle",
                        "Remove Curse",
                        "Revivify"
                    }
                },
                {
                    4, new List<string>
                    {
                        "Banishment",
                        "Death Ward",
                        "Locate Creature"
                    }
                },
                {
                    5, new List<string>
                    {
                        "Dispel Evil and Good",
                        "Geas",
                        "Raise Dead"
                    }
                }
            };
        }

        public Dictionary<int, IEnumerable<string>> GetRangerSpells()
        {
            return new Dictionary<int, IEnumerable<string>>
            {
                {
                    1, new List<string>
                    {
                        "Alarm",
                        "Animal Friendship",
                        "Cure Wounds",
                        "Detect Magic",
                        "Detect Poison and Disease",
                        "Fog Cloud",
                        "Goodberry",
                        "Hunter's Mark",
                        "Jump",
                        "Longstrider",
                        "Speak with Animals"
                    }
                },
                {
                    2, new List<string>
                    {
                        "Animal Messenger",
                        "Barkskin",
                        "Darkvision",
                        "Find Traps",
                        "Lesser Restoration",
                        "Locate Animals or Plants",
                        "Locate Object",
                        "Pass without Trace",
                        "Protection from Poison",
                        "Silence",
                        "Spike Growth"
                    }
                },
                {
                    3, new List<string>
                    {
                        "Conjure Animals",
                        "Daylight",
                        "Nondetection",
                        "Plant Growth",
                        "Protection from Energy",
                        "Speak with Plants",
                        "Water Breathing",
                        "Water Walk",
                        "Wind Wall"
                    }
                },
                {
                    4, new List<string>
                    {
                        "Conjure Woodland Beings",
                        "Freedom of Movement",
                        "Locate Creature",
                        "Stoneskin"
                    }
                },
                {
                    5, new List<string>
                    {
                        "Commune with Nature",
                        "Tree Stride"
                    }
                }
            };
        }

        public Dictionary<int, IEnumerable<string>> GetSorcererSpells()
        {
            return new Dictionary<int, IEnumerable<string>>
            {
                {
                    0, new List<string>
                    {
                        "Acid Splash",
                        "Chill Touch",
                        "Dancing Lights",
                        "Fire Bolt",
                        "Light",
                        "Mage Hand",
                        "Mending",
                        "Message",
                        "Minor Illusion",
                        "Poison Spray",
                        "Prestidigitation",
                        "Ray of Frost",
                        "Shocking Grasp",
                        "True Strike"
                    }
                },
                {
                    1, new List<string>
                    {
                        "Burning Hands",
                        "Charm Person",
                        "Color Spray",
                        "Comprehend Languages",
                        "Detect Magic",
                        "Disguise Self",
                        "Expeditious Retreat",
                        "False Life",
                        "Feather Fall",
                        "Fog Cloud",
                        "Jump",
                        "Mage Armor",
                        "Magic Missile",
                        "Shield",
                        "Silent Image",
                        "Sleep",
                        "Thunderwave"
                    }
                },
                {
                    2, new List<string>
                    {
                        "Alter Self",
                        "Blindness/Deafness",
                        "Blur",
                        "Darkness",
                        "Darkvision",
                        "Detect Thoughts",
                        "Enhance Ability",
                        "Enlarge/Reduce",
                        "Gust of Wind",
                        "Hold Person",
                        "Invisibility",
                        "Knock",
                        "Levitate",
                        "Mirror Image",
                        "Misty Step",
                        "Scorching Ray",
                        "See Invisibility",
                        "Shatter",
                        "Spider Climb",
                        "Suggestion",
                        "Web"
                    }
                },
                {
                    3, new List<string>
                    {
                        "Blink",
                        "Clairvoyance",
                        "Counterspell",
                        "Daylight",
                        "Dispel Magic",
                        "Fear",
                        "Fireball",
                        "Fly",
                        "Gaseous Form",
                        "Haste",
                        "Hypnotic Pattern",
                        "Lightning Bolt",
                        "Major Image",
                        "Protection from Energy",
                        "Sleet Storm",
                        "Slow",
                        "Stinking Cloud",
                        "Tongues",
                        "Water Breathing",
                        "Water Walk"
                    }
                },
                {
                    4, new List<string>
                    {
                        "Banishment",
                        "Blight",
                        "Confusion",
                        "Dimension Door",
                        "Dominate Beast",
                        "Greater Invisibility",
                        "Ice Storm",
                        "Polymorph",
                        "Stoneskin",
                        "Wall of Fire"
                    }
                },
                {
                    5, new List<string>
                    {
                        "Animate Objects",
                        "Cloudkill",
                        "Cone of Cold",
                        "Creation",
                        "Dominate Person",
                        "Hold Monster",
                        "Insect Plague",
                        "Seeming",
                        "Telekinesis",
                        "Teleportation Circle",
                        "Wall of Stone"
                    }
                },
                {
                    6, new List<string>
                    {
                        "Chain Lightning",
                        "Circle of Death",
                        "Disintegrate",
                        "Eyebite",
                        "Globe of Invulnerability",
                        "Mass Suggestion",
                        "Move Earth",
                        "Sunbeam",
                        "True Seeing"
                    }
                },
                {
                    7, new List<string>
                    {
                        "Delayed Blast Fireball",
                        "Etherealness",
                        "Finger of Death",
                        "Fire Storm",
                        "Plane Shift",
                        "Prismatic Spray",
                        "Reverse Gravity",
                        "Teleport"
                    }
                },
                {
                    8, new List<string>
                    {
                        "Dominate Monster",
                        "Earthquake",
                        "Incendiary Cloud",
                        "Power Word Stun",
                        "Sunburst"
                    }
                },
                {
                    9, new List<string>
                    {
                        "Gate",
                        "Meteor Swarm",
                        "Power Word Kill",
                        "Time Stop",
                        "Wish"
                    }
                }
            };
        }

        public Dictionary<int, IEnumerable<string>> GetWarlockSpells()
        {
            return new Dictionary<int, IEnumerable<string>>
            {
                {
                    0, new List<string>
                    {
                        "Chill Touch",
                        "Eldritch Blast",
                        "Mage Hand",
                        "Minor Illusion",
                        "Poison Spray",
                        "Prestidigitation",
                        "True Strike"
                    } 
                },
                {
                    1, new List<string>
                    {
                        "Charm Person",
                        "Comprehend Languages",
                        "Expeditious Retreat",
                        "Hellish Rebuke",
                        "Illusory Script",
                        "Protection from Evil and Good",
                        "Unseen Servant"
                    }
                },
                {
                    2, new List<string>
                    {
                        "Darkness",
                        "Enthrall",
                        "Hold Person",
                        "Invisibility",
                        "Mirror Image",
                        "Misty Step",
                        "Ray of Enfeeblement",
                        "Shatter",
                        "Spider Climb",
                        "Suggestion"
                    }
                },
                {
                    3, new List<string>
                    {
                        "Counterspell",
                        "Dispel Magic",
                        "Fear",
                        "Fly",
                        "Gaseous Form",
                        "Hypnotic Pattern",
                        "Magic Circle",
                        "Major Image",
                        "Remove Curse",
                        "Tongues",
                        "Vampiric Touch"
                    }
                },
                {
                    4, new List<string>
                    {
                        "Banishment",
                        "Blight",
                        "Dimension Door",
                        "Hallucinatory Terrain"
                    }
                },
                {
                    5, new List<string>
                    {
                        "Contact Other Plane",
                        "Dream",
                        "Hold Monster",
                        "Scrying"
                    }
                },
                {
                    6, new List<string>
                    {
                        "Circle of Death",
                        "Conjure Fey",
                        "Create Undead",
                        "Eyebite",
                        "Flesh to Stone",
                        "Mass Suggestion",
                        "True Seeing"
                    }
                },
                {
                    7, new List<string>
                    {
                        "Etherealness",
                        "Finger of Death",
                        "Forcecage",
                        "Plane Shift"
                    }
                },
                {
                    8, new List<string>
                    {
                        "Demiplane",
                        "Dominate Monster",
                        "Feeblemind",
                        "Glibness",
                        "Power Word Stun"
                    }
                },
                {
                    9, new List<string>
                    {
                        "Astral Projection",
                        "Foresight",
                        "Imprisonment",
                        "Power Word Kill",
                        "True Polymorph"
                    }
                }
            };
        }

        public Dictionary<int, IEnumerable<string>> GetWizardSpells()
        {
            return new Dictionary<int, IEnumerable<string>>
            {
                {
                    0, new List<string>
                    {
                        "Acid Splash",
                        "Chill Touch",
                        "Dancing Lights",
                        "Fire Bolt",
                        "Light",
                        "Mage Hand",
                        "Mending",
                        "Message",
                        "Minor Illusion",
                        "Poison Spray",
                        "Prestidigitation",
                        "Ray of Frost",
                        "Shocking Grasp",
                        "True Strike"
                    }
                },
                { 
                    1, new List<string>
                    {
                        "Alarm",
                        "Burning Hands",
                        "Charm Person",
                        "Color Spray",
                        "Comprehend Languages",
                        "Detect Magic",
                        "Disguise Self",
                        "Expeditious Retreat",
                        "False Life",
                        "Feather Fall",
                        "Find Familiar",
                        "Floating Disk",
                        "Fog Cloud",
                        "Grease",
                        "Hideous Laughter",
                        "Identify",
                        "Illusory Script",
                        "Jump",
                        "Longstrider",
                        "Mage Armor",
                        "Magic Missile",
                        "Protection from Evil and Good",
                        "Shield",
                        "Silent Image",
                        "Sleep",
                        "Thunderwave",
                        "Unseen Servant"
                    }
                },
                {
                    2, new List<string>
                    {
                        "Acid Arrow",
                        "Alter Self",
                        "Arcane Lock",
                        "Arcanist's Magic Aura",
                        "Blindness/Deafness",
                        "Blur",
                        "Continual Flame",
                        "Darkness",
                        "Darkvision",
                        "Detect Thoughts",
                        "Enlarge/Reduce",
                        "Flaming Sphere",
                        "Gentle Repose",
                        "Gust of Wind",
                        "Hold Person",
                        "Invisibility",
                        "Knock",
                        "Levitate",
                        "Locate Object",
                        "Magic Mouth",
                        "Magic Weapon",
                        "Mirror Image",
                        "Misty Step",
                        "Ray of Enfeeblement",
                        "Rope Trick",
                        "Scorching Ray",
                        "See Invisibility",
                        "Shatter",
                        "Spider Climb",
                        "Suggestion",
                        "Web"
                    }
                },
                {
                    3, new List<string>
                    {
                        "Animate Dead",
                        "Bestow Curse",
                        "Blink",
                        "Clairvoyance",
                        "Counterspell",
                        "Dispel Magic",
                        "Fear",
                        "Fireball",
                        "Fly",
                        "Gaseous Form",
                        "Glyph of Warding",
                        "Haste",
                        "Hypnotic Pattern",
                        "Lightning Bolt",
                        "Magic Circle",
                        "Major Image",
                        "Nondetection",
                        "Phantom Steed",
                        "Protection from Energy",
                        "Remove Curse",
                        "Sending",
                        "Sleet Storm",
                        "Slow",
                        "Stinking Cloud",
                        "Tiny Hut",
                        "Tongues",
                        "Vampiric Touch",
                        "Water Breathing"
                    }
                },
                {
                    4, new List<string>
                    {
                        "Arcane Eye",
                        "Banishment",
                        "Black Tentacles",
                        "Blight",
                        "Confusion",
                        "Conjure Minor Elementals",
                        "Control Water",
                        "Dimension Door",
                        "Fabricate",
                        "Faithful Hound",
                        "Fire Shield",
                        "Greater Invisibility",
                        "Hallucinatory Terrain",
                        "Ice Storm",
                        "Locate Creature",
                        "Phantasmal Killer",
                        "Polymorph",
                        "Private Sanctum",
                        "Resilient Sphere",
                        "Secret Chest",
                        "Stone Shape",
                        "Stoneskin",
                        "Wall of Fire"
                    }
                },
                {
                    5, new List<string>
                    {
                        "Animate Objects",
                        "Arcane Hand",
                        "Cloudkill",
                        "Cone of Cold",
                        "Conjure Elemental",
                        "Contact Other Plane",
                        "Creation",
                        "Dominate Person",
                        "Dream",
                        "Geas",
                        "Hold Monster",
                        "Legend Lore",
                        "Mislead",
                        "Modify Memory",
                        "Passwall",
                        "Planar Binding",
                        "Scrying",
                        "Seeming",
                        "Telekinesis",
                        "Telepathic Bond",
                        "Teleportation Circle",
                        "Wall of Force",
                        "Wall of Stone"
                    }
                },
                {
                    6, new List<string>
                    {
                        "Chain Lightning",
                        "Circle of Death",
                        "Contingency",
                        "Create Undead",
                        "Disintegrate",
                        "Eyebite",
                        "Flesh to Stone",
                        "Freezing Sphere",
                        "Globe of Invulnerability",
                        "Guards and Wards",
                        "Instant Summons",
                        "Irresistible Dance",
                        "Magic Jar",
                        "Mass Suggestion",
                        "Move Earth",
                        "Programmed Illusion",
                        "Sunbeam",
                        "True Seeing",
                        "Wall of Ice"
                    }
                },
                {
                    7, new List<string>
                    {
                        "Arcane Sword",
                        "Delayed Blast Fireball",
                        "Etherealness",
                        "Finger of Death",
                        "Forcecage",
                        "Magnificent Mansion",
                        "Mirage Arcane",
                        "Plane Shift",
                        "Prismatic Spray",
                        "Project Image",
                        "Reverse Gravity",
                        "Sequester",
                        "Simulacrum",
                        "Symbol",
                        "Teleport"
                    }
                },
                {
                    8, new List<string>
                    {
                        "Antimagic Field",
                        "Antipathy/Sympathy",
                        "Clone",
                        "Control Weather",
                        "Demiplane",
                        "Dominate Monster",
                        "Feeblemind",
                        "Incendiary Cloud",
                        "Maze",
                        "Mind Blank",
                        "Power Word Stun",
                        "Sunburst"
                    }
                },
                {
                    9, new List<string>
                    {
                        "Astral Projection",
                        "Foresight",
                        "Gate",
                        "Imprisonment",
                        "Meteor Swarm",
                        "Power Word Kill",
                        "Prismatic Wall",
                        "Shapechange",
                        "Time Stop",
                        "True Polymorph",
                        "Weird",
                        "Wish"
                    }
                }
            };
        }
    }                
}                    