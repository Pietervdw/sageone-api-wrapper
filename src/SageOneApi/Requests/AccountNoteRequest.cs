using System;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
	public class AccountNoteRequest : RequestBase, IAccountNoteRequest
	{
		public AccountNoteRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

		public AccountNote Get(int id)
		{
			var response = _client.Execute<AccountNote>(new RestRequest(String.Format("AccountNote/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
			return response.Data;
		}

		public PagingResponse<AccountNote> Get(string filter = "", int skip = 0)
		{
			var url = string.Format("AccountNote/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

			if (!string.IsNullOrEmpty(filter))
				url = string.Format("AccountNote/Get?apikey={0}&companyid={1}&$filter={2}", _apiKey, _companyId, filter);

			if (skip > 0)
				url += "&$skip=" + skip;

			var request = new RestRequest(url, Method.GET);
			request.RequestFormat = DataFormat.Json;

			var response = _client.Execute(request);
			JsonDeserializer deserializer = new JsonDeserializer();

			return deserializer.Deserialize<PagingResponse<AccountNote>>(response);
		}

		public AccountNote Save(AccountNote accountNote)
		{
			var url = string.Format("AccountNote/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
			var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
			request.RequestFormat = DataFormat.Json;
			request.AddBody(accountNote);
			var response = _client.Execute<AccountNote>(request);
			return response.Data;
		}

		public bool Delete(int id)
		{
			var url = string.Format("AccountNote/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
			var response = _client.Execute<AccountNote>(new RestRequest(url, Method.DELETE));
			return response.ResponseStatus == ResponseStatus.Completed;
		}
	}
}