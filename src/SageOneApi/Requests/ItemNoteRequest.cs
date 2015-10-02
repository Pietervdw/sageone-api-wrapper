using System;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class ItemNoteRequest:RequestBase, IItemNoteRequest
    {
        public ItemNoteRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

        public ItemNote Get(int id)
        {
            var response = _client.Execute<ItemNote>(new RestRequest(String.Format("ItemNote/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
            return response.Data;
        }

        public PagingResponse<ItemNote> Get(string filter = "", int skip = 0)
        {
            var url = string.Format("ItemNote/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

            if (!string.IsNullOrEmpty(filter))
                url = string.Format("ItemNote/Get?apikey={0}&companyid={1}&$filter={2}", _apiKey, _companyId, filter);

            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            return deserializer.Deserialize<PagingResponse<ItemNote>>(response);
        }

        public ItemNote Save(ItemNote itemNote)
        {
            var url = string.Format("ItemNote/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(itemNote);
            var response = _client.Execute<ItemNote>(request);
            return response.Data;
        }

        public bool Delete(int id)
        {
            var url = string.Format("ItemNote/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
            var response = _client.Execute<ItemNote>(new RestRequest(url, Method.DELETE));
            return response.ResponseStatus == ResponseStatus.Completed;
        }
    }
}