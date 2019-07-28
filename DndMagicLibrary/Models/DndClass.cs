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
        public int Index { get; set; }
        public string Description { get; set; }
        public int Hit_Die { get; set; }
        [JsonProperty("spellcasting")]
        public SpellCasting SpellCasting { get; set; }

        [HttpGet]
        public async Task<SpellCasting> GetSpellcastingData()
        {
            string url = $"http://www.dnd5eapi.co/api/spellcasting/{Index}";
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
        public async Task<DndClass> GetClassData()
        {
            var url = $"classes/{Index}";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(ApiHelper.ApiClient.BaseAddress + url))
            {
                if (response.IsSuccessStatusCode)
                {
                    DndClass dndClass = await response.Content.ReadAsAsync<DndClass>();
                    return dndClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}