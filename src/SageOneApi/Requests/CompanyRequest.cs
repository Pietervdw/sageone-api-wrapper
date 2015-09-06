using RestSharp;
using RestSharp.Deserializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class CompanyRequest : RequestBase, ICompanyRequest
    {
        public CompanyRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

        public PagingResponse<Company> Current()
        {
            var url = string.Format("Company/Get?apikey={0}", _apiKey);
            var request = new RestRequest(url, Method.GET);
            request.RequestFormat=DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();
            return deserializer.Deserialize<PagingResponse<Company>>(response);
        }
    }
}