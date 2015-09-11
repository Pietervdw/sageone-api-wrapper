using System;
using System.Collections.Generic;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
	public class AccountRequest : RequestBase, IAccountRequest
	{
		public AccountRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

		public Account Get(int id)
		{
			var response = _client.Execute<Account>(new RestRequest(String.Format("Account/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
			return response.Data;
		}

		public PagingResponse<Account> Get(bool includeSystemAccounts = false, int skip = 0)
		{
			var url = string.Format("Account/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

			if (includeSystemAccounts)
				url = string.Format("Account/GetWithSystemAccounts?apikey={0}&companyid={1}", _apiKey, _companyId);

			if (skip > 0)
				url += "&$skip=" + skip;

			var request = new RestRequest(url, Method.GET);
			request.RequestFormat = DataFormat.Json;

			var response = _client.Execute(request);
			JsonDeserializer deserializer = new JsonDeserializer();

			return deserializer.Deserialize<PagingResponse<Account>>(response);
		}

		public PagingResponse<Account> GetByCategory(int categoryId)
		{
			var url = string.Format("Account/GetAccountsByCategoryId/{0}?apikey={1}&companyid={2}", categoryId, _apiKey, _companyId);

			var request = new RestRequest(url, Method.GET);
			request.RequestFormat = DataFormat.Json;

			var response = _client.Execute(request);
			JsonDeserializer deserializer = new JsonDeserializer();

			return deserializer.Deserialize<PagingResponse<Account>>(response);
		}

		public Account Save(Account account)
		{
			var url = string.Format("Account/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
			var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
			request.RequestFormat = DataFormat.Json;
			request.AddBody(account);
			var response = _client.Execute<Account>(request);
			return response.Data;
		}

		public bool Delete(int id)
		{
			var url = string.Format("Account/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
			var response = _client.Execute<Account>(new RestRequest(url, Method.DELETE));
			return response.ResponseStatus == ResponseStatus.Completed;
		}
	}
}