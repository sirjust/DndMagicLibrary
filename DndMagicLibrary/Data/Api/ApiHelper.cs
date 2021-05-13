using DndMagicLibrary.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DndMagicLibrary.Data.Api
{
    public class ApiHelper : IApiHelper
    {
        public ApiHelper(HttpClient client)
        {
            ApiClient = client;
            InitializeClient(ApiClient);
        }

        public HttpClient ApiClient { get; set; }
        public void InitializeClient(HttpClient client)
        {
            client.BaseAddress = new Uri("http://www.dnd5eapi.co/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [HttpGet]
        public async Task<SpellCasting> GetSpellcastingData(int spellCastingIndex)
        {
            string url = $"http://www.dnd5eapi.co/api/spellcasting/{spellCastingIndex}";
            SpellCasting spellCasting = new SpellCasting();
            using (HttpResponseMessage response = await ApiClient.GetAsync(url))
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
            spellCasting.SpellcastingAbility = await GetSpellcastingAbility(url); 
            return spellCasting;
        }

        [HttpGet]
        public async Task<DndClass> GetClassData(DndClass myClass)
        {
            var url = $"classes/{myClass.Name.ToLower()}";
            using (HttpResponseMessage response = await ApiClient.GetAsync(ApiClient.BaseAddress + url))
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

        [HttpGet]
        public async Task<SpellcastingAbility> GetSpellcastingAbility(string url)
        {
            using (HttpResponseMessage response = await ApiClient.GetAsync(url))
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


        [HttpGet]
        public async Task<Spell> GetSpellData(string spell)
        {
            var url = $"spells/{spell}";
            using (HttpResponseMessage response = await ApiClient.GetAsync(ApiClient.BaseAddress + url))
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
    }

    public interface IApiHelper
    {
        HttpClient ApiClient { get; set; }
        void InitializeClient(HttpClient client);
        Task<SpellCasting> GetSpellcastingData(int spellCastingIndex);
        Task<SpellcastingAbility> GetSpellcastingAbility(string url);
        Task<DndClass> GetClassData(DndClass myClass);
        Task<Spell> GetSpellData(string spell);
    }
}