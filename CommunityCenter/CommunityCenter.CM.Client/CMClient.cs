using Simple.OData.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace CommunityCenter.CM.Client
{
    public class CMClient
    {
        private ODataClient _client;
        private HttpClient _httpClient;
        public CMClient()
        {
            HttpClient httpClient = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true });
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(delegate { return true; });
            httpClient.BaseAddress = new Uri("https://Lab-CM.Home.Lab/AdminService/wmi");
            _httpClient = httpClient;
            var settings = new ODataClientSettings(httpClient);
            _client = new ODataClient(settings);
        }

        public ODataClient Client
        {
            get { return _client; }
        }

        public async System.Threading.Tasks.Task<T[]> GetArrayAsync<T>()
            where T: class
        {
            var results = await _client.For<T>().FindEntriesAsync();
            return results.ToArray();
        }
        public async System.Threading.Tasks.Task<int> GetCountAsync(string objectName)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"wmi/{objectName}/$count");
            if (response.IsSuccessStatusCode)
            {
                var strResponse = await response.Content.ReadAsStringAsync();
                if (int.TryParse(strResponse, out int intResponse))
                {
                    return intResponse;
                }
            }
            return 0;
        }
    }
}
