using DndMagicLibrary.Helpers;
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
        public string SpellcastingUrl { get; set; }
        public int Index { get; set; }
        public string Description { get; set; }
        public int Hit_Die { get; set; }
        public SpellCasting SpellCasting { get; set; } = new SpellCasting();
        public Spellcasting_Ability SpellCasting_Ability { get; set; }

        [HttpGet]
        public async Task<SpellCasting> GetSpellcastingData(int index)
        {
            string url = $"http://www.dnd5eapi.co/api/spellcasting/{index}";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                SpellCasting spellCasting = new SpellCasting();
                if (response.IsSuccessStatusCode)
                {
                    spellCasting = await response.Content.ReadAsAsync<SpellCasting>();
                    return spellCasting;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        [HttpGet]
        public async Task<string> GetSpellcastingUrl()
        {
            string url = $"http://www.dnd5eapi.co/api/classes/{Index}";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                string spellCasting;
                if (response.IsSuccessStatusCode)
                {
                    spellCasting = await response.Content.ReadAsAsync<string>();
                    return spellCasting;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
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