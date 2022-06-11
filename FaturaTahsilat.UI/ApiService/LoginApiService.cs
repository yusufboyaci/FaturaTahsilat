using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FaturaTahsilat.UI.ApiService
{
    public class LoginApiService
    {

        private readonly HttpClient _httpClient;
        public LoginApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
      
    }
}
