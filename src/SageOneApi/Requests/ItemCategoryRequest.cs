using System;
using System.Collections.Generic;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
	public class ItemCategoryRequest : RequestBase, IItemCategoryRequest
	{
		public ItemCategoryRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

		public ItemCategory Get(int id)
		{
			var response = _client.Execute<ItemCategory>(new RestRequest(String.Format("ItemCategory/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
			return response.Data;
		}

		public PagingResponse<List<ItemCategory>> Get(string filter = "")
		{
			var url = string.Format("ItemCategory/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

			if (!string.IsNullOrEmpty(filter))
				url = string.Format("ItemCategory/Get?apikey={0}&companyid={1}&$filter={2}", _apiKey, _companyId, filter);

			var request = new RestRequest(url, Method.GET);
			request.RequestFormat = DataFormat.Json;

			var response = _client.Execute(request);
			JsonDeserializer deserializer = new JsonDeserializer();

			return deserializer.Deserialize<PagingResponse<List<ItemCategory>>>(response);
		}

		public ItemCategory Save(ItemCategory category)
		{
			var url = string.Format("ItemCategory/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
			var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
			request.RequestFormat = DataFormat.Json;
			request.AddBody(category);
			var response = _client.Execute<ItemCategory>(request);
			return response.Data;
		}

		public bool Delete(int id)
		{
			var url = string.Format("ItemCategory/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
			var response = _client.Execute<Company>(new RestRequest(url, Method.DELETE));
			return response.ResponseStatus == ResponseStatus.Completed;
		}
	}
}