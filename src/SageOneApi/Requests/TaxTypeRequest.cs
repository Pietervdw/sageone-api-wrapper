using RestSharp;
using RestSharp.Deserializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class TaxTypeRequest : RequestBase, ITaxTypeRequest
    {
        public TaxTypeRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

        public PagingResponse<TaxType> Get(int skip = 0)
        {
            var url = string.Format("TaxType/Get?apikey={0}&companyid={1}", _apiKey, _companyId);
            
            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            return deserializer.Deserialize<PagingResponse<TaxType>>(response);
        }
    }
}