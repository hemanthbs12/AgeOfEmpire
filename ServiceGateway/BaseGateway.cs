using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AgeOfEmpire.ServiceGateway
{
    public class BaseGateway
    {
        private readonly HttpClient _client = new HttpClient();

        public BaseGateway()
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected virtual T GetAsync<T>(string uri)
        {
            HttpResponseMessage response = _client.GetAsync(uri).Result;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<T>(json);
            }
            else
            {
                var errorDetail = response.Content.ReadAsStringAsync().Result;

                throw new Exception(string.Format("{0}, {1}", response.ReasonPhrase, errorDetail));
            }
        }
    }
}
