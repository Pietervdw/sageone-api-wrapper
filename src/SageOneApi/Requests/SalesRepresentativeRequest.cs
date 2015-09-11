using System;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
	public class SalesRepresentativeRequest : RequestBase, ISalesRepresentativeRequest
	{
		public SalesRepresentativeRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

		public SalesRepresentative Get(int id)
		{
			var response = _client.Execute<SalesRepresentative>(new RestRequest(String.Format("SalesRepresentative/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
			return response.Data;
		}

		public PagingResponse<SalesRepresentative> Get(string filter = "", int skip = 0)
		{
			var url = string.Format("SalesRepresentative/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

			if (!string.IsNullOrEmpty(filter))
				url = string.Format("SalesRepresentative/Get?apikey={0}&companyid={1}&$filter={2}", _apiKey, _companyId, filter);

			if (skip > 0)
				url += "&$skip=" + skip;

			var request = new RestRequest(url, Method.GET);
			request.RequestFormat = DataFormat.Json;

			var response = _client.Execute(request);
			JsonDeserializer deserializer = new JsonDeserializer();

			return deserializer.Deserialize<PagingResponse<SalesRepresentative>>(response);
		}

		public SalesRepresentative Save(SalesRepresentative customer)
		{
			var url = string.Format("SalesRepresentative/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
			var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
			request.RequestFormat = DataFormat.Json;
			request.AddBody(customer);
			var response = _client.Execute<SalesRepresentative>(request);
			return response.Data;
		}

		public bool Delete(int id)
		{
			var url = string.Format("SalesRepresentative/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
			var response = _client.Execute<SalesRepresentative>(new RestRequest(url, Method.DELETE));
			return response.ResponseStatus == ResponseStatus.Completed;
		}

		public bool HasActivity(int id)
		{
			var url = string.Format("SalesRepresentative/HasActivity/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
			var response = _client.Execute<bool>(new RestRequest(url, Method.GET));
			return response.Data;
		}
	}
}