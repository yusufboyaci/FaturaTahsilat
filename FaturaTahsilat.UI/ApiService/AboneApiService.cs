using FaturaTahsilat.UI.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FaturaTahsilat.UI.ApiService
{
    public class AboneApiService
    {
        private readonly HttpClient _httpClient;
        public AboneApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<AboneDto>> GetAllAsync()
        {
            IEnumerable<AboneDto> aboneDtos;
            var response = await _httpClient.GetAsync("abone");
            if (response.IsSuccessStatusCode)
            {
                aboneDtos = JsonConvert.DeserializeObject<IEnumerable<AboneDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                aboneDtos = null;
            }
            return aboneDtos;
        }
       
        public async Task<AboneDto> AddAsync(AboneDto aboneDto)
        {
            
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(aboneDto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("abone", stringContent);
            if (response.IsSuccessStatusCode)
            {
                aboneDto = JsonConvert.DeserializeObject<AboneDto>(await response.Content.ReadAsStringAsync());
                return aboneDto;
            }
            else
            {
                //loglama yap
                return null;
            }
        }
    }
}
