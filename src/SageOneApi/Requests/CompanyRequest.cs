using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Extensions;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class CompanyRequest : RequestBase, ICompanyRequest
    {
        public CompanyRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public ResultRoot<Company> Current()
        {
            var url = string.Format("Company/Get?apikey={0}", _apiKey);
            var request = new RestRequest(url, Method.GET);
            request.RequestFormat=DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();
            return deserializer.Deserialize<ResultRoot<Company>>(response);
        }
    }
}