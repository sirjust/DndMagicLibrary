using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace DndMagicLibrary.Models
{
    public class Spell : ISpell
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Level { get; set; }
        [JsonProperty("desc")]
        public IEnumerable<string> Description { get; set; }
        public IEnumerable<string> Components { get; set; }
        public string Range { get; set; }
        public string Material { get; set; }
        public bool Ritual { get; set; }
        public string Duration { get; set; }
        public bool Concentration { get; set; }
        [JsonProperty("casting_time")]
        public string CastingTime { get; set; }
        public School School { get; set; }

        public string ConvertSpellName(string name)
        {
            var splitUpName = name.ToLower().Split(' ');
            var validatedName = RemoveNames(splitUpName);
            return string.Join("-", validatedName);
        }

        public IEnumerable<string> RemoveNames(string[] splitUpName)
        {
            // We need to remove names like Mordekainen's and Otto's
            return splitUpName.Where(x => !x.Contains("'s"));
        }
    }
}