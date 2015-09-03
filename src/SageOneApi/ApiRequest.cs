using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using SageOneApi.Requests;

namespace SageOneApi
{
    public class ApiRequest
    {
        private readonly string _apiKey;
        private readonly int _companyId;
        private readonly IRestClient _client;

        public CompanyRequest CompanyRequest { get { return new CompanyRequest(_client, _apiKey); } }
        public CustomerRequest CustomerRequest { get { return new CustomerRequest(_client, _apiKey,_companyId); } }

        public ApiRequest(string username,string password, string apiKey, int companyId)
        {
            _apiKey = apiKey;
            _companyId = companyId;

            _client = new RestClient
            {
                BaseUrl = new Uri("https://accounting.sageone.co.za/api/1.1.1/"),
                Authenticator = new HttpBasicAuthenticator(username,password)
            };
        }
    }
}
