using System.Collections.Generic;

namespace DndMagicLibrary.Models
{
    public interface ISpell
    {
        string Name { get; set; }
        string Url { get; set; }
        int Level { get; set; }
        IEnumerable<string> Description { get; set; }
        IEnumerable<string> Components { get; set; }
        string Range { get; set; }
        string Material { get; set; }
        bool Ritual { get; set; }
        string Duration { get; set; }
        bool Concentration { get; set; }
        string CastingTime { get; set; }
        School School { get; set; }
    }
}