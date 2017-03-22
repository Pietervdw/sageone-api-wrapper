using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class QuoteRequest:RequestBase, IQuoteRequest
    {
        public QuoteRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

        public Quote Get(int id)
        {
            var response = _client.Execute<Quote>(new RestRequest(string.Format("Quote/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public PagingResponse<Quote> Get(bool includeDetail = false, bool includeCustomerDetails = false, string filter = "", int skip = 0)
        {
            var url = string.Format("Quote/Get?companyid={0}&includeDetail={1}&includeCustomerDetails={2}&apikey={3}", _companyId, includeDetail.ToString().ToLower(), includeCustomerDetails.ToString().ToLower(), _apiKey);

            if (!string.IsNullOrEmpty(filter))
                url = string.Format("Quote/Get?includeDetail={0}&includeCustomerDetails={1}?apikey={2}&companyid={3}&$filter={4}", includeDetail, includeCustomerDetails, _apiKey, _companyId, filter);

            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return deserializer.Deserialize<PagingResponse<Quote>>(response);
        }

        public Quote Save(Quote quote)
        {
            var url = string.Format("Quote/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(quote);
            var response = _client.Execute<Quote>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public Quote Calculate(Quote quote)
        {
            var url = string.Format("Quote/Calculate?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.RequestFormat = DataFormat.Json;
            request.AddBody(quote);
            var response = _client.Execute<Quote>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public bool Email(EmailRequest email)
        {
            var url = string.Format("Quote/Email?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(email);
            var response = _client.Execute<EmailRequest>(request);
            return response.ResponseStatus == ResponseStatus.Completed;
        }
    }

}