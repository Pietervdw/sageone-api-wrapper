using System;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
	public class AccountBalanceRequest : RequestBase, IAccountBalanceRequest
	{
		public AccountBalanceRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

		public AccountBalance Get(DateTime fromDate, DateTime toDate)
		{
			var url = string.Format("AccountBalance/Get?apikey={0}&companyid={1}", _apiKey, _companyId);
			var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
			request.RequestFormat = DataFormat.Json;
			var requestObject = new AccountBalanceRequestObject { FromDate = fromDate, ToDate = toDate };
			request.AddBody(requestObject);
			var response = _client.Execute<AccountBalance>(request);
			return response.Data;
		}

		public PagingResponse<AccountBalance> GetAccountBudgetsById(int budgetId, string filter = "", int skip = 0)
		{
			var url = string.Format("AccountBalance/GetAccountBudgetsById?budgetId={0}&apikey={1}&companyid={2}",budgetId, _apiKey, _companyId);

			if (!string.IsNullOrEmpty(filter))
				url = string.Format("AccountBalance/GetAccountBudgetsById?budgetId={0}&apikey={1}&companyid={2}&$filter={3}",budgetId, _apiKey, _companyId, filter);

			if (skip > 0)
				url += "&$skip=" + skip;

			var request = new RestRequest(url, Method.GET);
			request.RequestFormat = DataFormat.Json;

			var response = _client.Execute(request);
			JsonDeserializer deserializer = new JsonDeserializer();

			return deserializer.Deserialize<PagingResponse<AccountBalance>>(response);
		}

		public PagingResponse<AccountBalance> GetAccountBudgets(string filter = "", int skip = 0)
		{
			var url = string.Format("AccountBalance/GetAccountBudgets?apikey={0}&companyid={1}",  _apiKey, _companyId);

			if (!string.IsNullOrEmpty(filter))
				url = string.Format("AccountBalance/GetAccountBudgets?apikey={0}&companyid={1}&$filter={2}",  _apiKey, _companyId, filter);

			if (skip > 0)
				url += "&$skip=" + skip;

			var request = new RestRequest(url, Method.GET);
			request.RequestFormat = DataFormat.Json;

			var response = _client.Execute(request);
			JsonDeserializer deserializer = new JsonDeserializer();

			return deserializer.Deserialize<PagingResponse<AccountBalance>>(response);
		}
	}
}