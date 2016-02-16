using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
	public class ItemRequest : RequestBase, IItemRequest
	{
		public ItemRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

		public Item Get(int id)
		{
			var response = _client.Execute<Item>(new RestRequest(string.Format("Item/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
		}

		public PagingResponse<Item> Get(string filter = "", int skip = 0, bool includeAdditionalItemPrices=false)
		{
			var url = string.Format("Item/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

			if (!string.IsNullOrEmpty(filter))
				url = string.Format("Item/Get?apikey={0}&companyid={1}&$filter={2}", _apiKey, _companyId, filter);

			if (skip > 0)
				url += "&$skip=" + skip;

		    if (includeAdditionalItemPrices)
		        url += "&includeAdditionalItemPrices=true";

			var request = new RestRequest(url, Method.GET);
			request.RequestFormat = DataFormat.Json;
			var response = _client.Execute(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            JsonDeserializer deserializer = new JsonDeserializer();
			return deserializer.Deserialize<PagingResponse<Item>>(response);
		}

	    public async Task<PagingResponse<Item>> GetAsync(string filter = "", int skip = 0, bool includeAdditionalItemPrices = false)
	    {
            var url = string.Format("Item/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

            if (!string.IsNullOrEmpty(filter))
                url = string.Format("Item/Get?apikey={0}&companyid={1}&$filter={2}", _apiKey, _companyId, filter);

            if (skip > 0)
                url += "&$skip=" + skip;

            if (includeAdditionalItemPrices)
                url += "&includeAdditionalItemPrices=true";

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;
            var response = await _client.ExecuteTaskAsync(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            JsonDeserializer deserializer = new JsonDeserializer();

            return deserializer.Deserialize<PagingResponse<Item>>(response);
        }

	    public Item Save(Item item)
		{
			var url = string.Format("Item/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
			var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
			request.RequestFormat = DataFormat.Json;
			request.AddBody(item);
			var response = _client.Execute<Item>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
		}

	    public async Task<Item> SaveAsync(Item item)
	    {
            var url = string.Format("Item/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(item);
            var response = await _client.ExecuteTaskAsync<Item>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

	    public bool Delete(int id)
		{
			var url = string.Format("Item/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
			var response = _client.Execute<Item>(new RestRequest(url, Method.DELETE));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.ResponseStatus == ResponseStatus.Completed;
		}
	}
}