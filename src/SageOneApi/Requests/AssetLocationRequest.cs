using System;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
	public class AssetLocationRequest : RequestBase, IAssetLocationLocationRequest
	{
		public AssetLocationRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

		public AssetLocation Get(int id)
		{
			var response = _client.Execute<AssetLocation>(new RestRequest(String.Format("AssetLocation/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
			return response.Data;
		}

		public PagingResponse<AssetLocation> Get(string filter = "", int skip = 0)
		{
			var url = string.Format("AssetLocation/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

			if (!string.IsNullOrEmpty(filter))
				url = string.Format("AssetLocation/Get?apikey={0}&companyid={1}&$filter={2}", _apiKey, _companyId, filter);

			if (skip > 0)
				url += "&$skip=" + skip;

			var request = new RestRequest(url, Method.GET);
			request.RequestFormat = DataFormat.Json;

			var response = _client.Execute(request);
			JsonDeserializer deserializer = new JsonDeserializer();

			return deserializer.Deserialize<PagingResponse<AssetLocation>>(response);
		}

		public AssetLocation Save(AssetLocation assetLocation)
		{
			var url = string.Format("AssetLocation/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
			var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
			request.RequestFormat = DataFormat.Json;
			request.AddBody(assetLocation);
			var response = _client.Execute<AssetLocation>(request);
			return response.Data;
		}

		public bool Delete(int id)
		{
			var url = string.Format("AssetLocation/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
			var response = _client.Execute<AssetLocation>(new RestRequest(url, Method.DELETE));
			return response.ResponseStatus == ResponseStatus.Completed;
		}
	}
}