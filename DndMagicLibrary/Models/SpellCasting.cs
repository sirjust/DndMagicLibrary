using DndMagicLibrary.Data.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DndMagicLibrary.Models
{
    public class SpellCasting
    {
        IApiHelper _helper;
        public SpellCasting(IApiHelper helper)
        {
            _helper = helper;
        }

        public string Url { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }
        [JsonProperty("spellcasting_ability")]
        public SpellcastingAbility SpellcastingAbility { get; set; }

        [HttpGet]
        async Task<SpellcastingAbility> GetSpellcastingAbility(string url)
        {
            using (HttpResponseMessage response = await _helper.ApiClient.GetAsync(url))
            {
                SpellcastingAbility ability = new SpellcastingAbility();
                if (response.IsSuccessStatusCode)
                {
                    JObject json = JObject.Parse(await response.Content.ReadAsStringAsync());
                    ability.Url = json["spellcasting_ability"]["url"].ToString();
                    ability.Name = json["spellcasting_ability"]["name"].ToString();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
                return ability;
            }
        }

        public async void SetSpellcastingAbility()
        {
            SpellcastingAbility = await GetSpellcastingAbility(Url);
        }
    }
}