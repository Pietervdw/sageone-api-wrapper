using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class AdditionalPriceListRequest : RequestBase, IAdditionalPriceListRequest
    {
        public AdditionalPriceListRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

        public AdditionalPriceList Get(int id)
        {
            var response = _client.Execute<AdditionalPriceList>(new RestRequest(string.Format("AdditionalPriceList/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
            return response.Data;
        }

        public PagingResponse<AdditionalPriceList> Get(string filter = "", int skip = 0)
        {
            var url = string.Format("AdditionalPriceList/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            return deserializer.Deserialize<PagingResponse<AdditionalPriceList>>(response);
        }

        public AdditionalPriceList Save(AdditionalPriceList pricelist)
        {
            var url = string.Format("AdditionalPriceList/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(pricelist);
            var response = _client.Execute<AdditionalPriceList>(request);
            return response.Data;
        }

        public bool Delete(int id)
        {
            var url = string.Format("AdditionalPriceList/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
            var response = _client.Execute<AdditionalPriceList>(new RestRequest(url, Method.DELETE));
            return response.ResponseStatus == ResponseStatus.Completed;
        }
    }
}
