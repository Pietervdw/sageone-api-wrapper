using System;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class TaxTypeRequest : RequestBase, ITaxTypeRequest
    {
        public TaxTypeRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }
        
        public TaxType Get(int id)
        {
            var response = _client.Execute<TaxType>(new RestRequest(string.Format("TaxType/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public PagingResponse<TaxType> Get(string filter = "", int skip = 0)
        {
            var url = string.Format("TaxType/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

            if (!string.IsNullOrEmpty(filter))
                url = string.Format("TaxType/Get?apikey={0}&companyid={1}&$filter={2}", _apiKey, _companyId, filter);

            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return deserializer.Deserialize<PagingResponse<TaxType>>(response);
        }

        public TaxType Save(TaxType taxType)
        {
            var url = string.Format("TaxType/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(taxType);
            var response = _client.Execute<TaxType>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public bool Delete(int id)
        {
            var url = string.Format("TaxType/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
            var response = _client.Execute<TaxType>(new RestRequest(url, Method.DELETE));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.ResponseStatus == ResponseStatus.Completed;
        }
    }
}