using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class AccountReceiptRequest: RequestBase, IAccountReceipt
    {
        public AccountReceiptRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

        public PagingResponse<AccountReceipt> Get(int skip = 0)
        {
            var url = string.Format("AccountReceipt/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            return deserializer.Deserialize<PagingResponse<AccountReceipt>>(response);
        }

        public Models.AccountReceipt Save(AccountReceipt accountReceipt)
        {
            var url = string.Format("AccountReceipt/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(accountReceipt);
            var response = _client.Execute<AccountReceipt>(request);
            return response.Data;
        }
    }
}