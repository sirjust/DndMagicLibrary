using DndMagicLibrary.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

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

        [HttpGet]
        public async Task<Spell> GetSpellData(string spell)
        {
            var url = $"spells/{spell}";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(ApiHelper.ApiClient.BaseAddress + url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var apiSpell = new Spell();
                    var data = await response.Content.ReadAsAsync<Spell>();
                    apiSpell.Name = data.Name;
                    apiSpell.Description = data.Description;
                    apiSpell.CastingTime = data.CastingTime;
                    apiSpell.Components = data.Components;
                    apiSpell.Range = data.Range;
                    apiSpell.Material = data.Material;
                    apiSpell.Level = data.Level;
                    apiSpell.School = data.School;
                    return apiSpell;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public string ConvertSpellName(string name)
        {
            var splitUpName = name.ToLower().Split(' ');
            return string.Join("-", splitUpName);
        }
    }
}