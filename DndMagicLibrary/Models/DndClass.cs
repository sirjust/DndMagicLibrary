using DndMagicLibrary.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DndMagicLibrary.Models
{
    public class DndClass : IDndClass
    {
        public string Name { get; set; }
        public int GeneralIndex { get; set; }
        public int SpellcastingIndex { get; set; }
        public string Description { get; set; }
        public int Hit_Die { get; set; }
        [JsonProperty("spellcasting")]
        public SpellCasting SpellCasting { get; set; }
        public List<List<Spell>> Spells { get; set; }

        public DndClass(string name, string description, int generalIndex, int spellcastingIndex)
        {
            Name = name;
            Description = description;
            GeneralIndex = generalIndex;
            SpellcastingIndex = spellcastingIndex;
        }

        [HttpGet]
        public async Task<SpellCasting> GetSpellcastingData()
        {
            string url = $"http://www.dnd5eapi.co/api/spellcasting/{SpellcastingIndex}";
            SpellCasting spellCasting = new SpellCasting();
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    spellCasting = await response.Content.ReadAsAsync<SpellCasting>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            spellCasting.SetSpellcastingAbility();
            return spellCasting;
        }

        [HttpGet]
        public async Task<DndClass> GetClassData(DndClass myClass)
        {
            var url = $"classes/{GeneralIndex}";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(ApiHelper.ApiClient.BaseAddress + url))
            {
                if (response.IsSuccessStatusCode)
                {
                    myClass = await response.Content.ReadAsAsync<DndClass>();
                    return myClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}