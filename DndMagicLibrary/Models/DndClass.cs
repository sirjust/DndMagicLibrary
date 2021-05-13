using DndMagicLibrary.Data;
using DndMagicLibrary.Data.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DndMagicLibrary.Models
{
    public class DndClass : IDndClass
    {
        IApiHelper _helper;
        AllClasses _allClasses;

        public DndClass() { }
        public DndClass(IApiHelper helper)
        {
            _helper = helper;
            _allClasses = new AllClasses(helper);
        }

        public string Name { get; set; }
        public int GeneralIndex { get; set; }
        public int SpellcastingIndex { get; set; }
        public string Description { get; set; }
        public int Hit_Die { get; set; }
        [JsonProperty("spellcasting")]
        public SpellCasting SpellCasting { get; set; }

        [JsonIgnore]
        public Dictionary<int, IEnumerable<string>> Spells { get; set; }

        public DndClass(IApiHelper helper, string name)
        {
            _helper = helper;
            _allClasses = new AllClasses(helper);

            Name = name;
            Description = _allClasses.GetDndClasses().Where(x => x.Name == name).FirstOrDefault().Description;
            GeneralIndex = _allClasses.GetDndClasses().Where(x => x.Name == name).FirstOrDefault().GeneralIndex;
            SpellcastingIndex = _allClasses.GetDndClasses().Where(x => x.Name == name).FirstOrDefault().SpellcastingIndex;
        }

        public DndClass(IApiHelper helper, string name, string description, int generalIndex, int spellcastingIndex)
        {
            _helper = helper;
            _allClasses = new AllClasses(helper);

            Name = name;
            Description = description;
            GeneralIndex = generalIndex;
            SpellcastingIndex = spellcastingIndex;
        }

        [HttpGet]
        public async Task<SpellCasting> GetSpellcastingData()
        {
            string url = $"http://www.dnd5eapi.co/api/spellcasting/{SpellcastingIndex}";
            SpellCasting spellCasting = new SpellCasting(_helper);
            using (HttpResponseMessage response = await _helper.ApiClient.GetAsync(url))
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
            var url = $"classes/{myClass.Name.ToLower()}";
            using (HttpResponseMessage response = await _helper.ApiClient.GetAsync(_helper.ApiClient.BaseAddress + url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<DndClass>();
                    // myClass = await response.Content.ReadAsAsync<DndClass>();
                    myClass.Hit_Die = data.Hit_Die;
                    myClass.SpellCasting = data.SpellCasting;
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