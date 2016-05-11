using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class BankTransactionRequest : RequestBase, IBankTransactionRequest
    {
        public BankTransactionRequest(IRestClient client, string apiKey, int companyId)
            : base(client, apiKey, companyId)
        {
        }

        public BankTransaction Get(int id)
        {
            var response =
                _client.Execute<BankTransaction>(
                    new RestRequest(
                        string.Format("BankTransaction/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId),
                        Method.GET));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public PagingResponse<BankTransaction> Get(string filter = "", int skip = 0)
        {
            var url = string.Format("BankTransaction/Get?apikey={0}&companyid={1}", _apiKey, _companyId);

            if (!string.IsNullOrEmpty(filter))
            {
                url = string.Format("BankTransaction/Get?apikey={0}&companyid={1}&$filter={2}", _apiKey, _companyId, filter);                   
            }

            if (skip > 0)
            {
                url += "&$skip=" + skip;
            }

            var request = new RestRequest(url, Method.GET) {RequestFormat = DataFormat.Json};

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return deserializer.Deserialize<PagingResponse<BankTransaction>>(response);



        }

        public BankTransaction Save(BankTransaction bankTransaction)
        {            
            var url = string.Format("BankTransaction/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST)
            {
                JsonSerializer = new JsonSerializer(),
                RequestFormat = DataFormat.Json
            };
            request.AddBody(bankTransaction);
            var response = _client.Execute<BankTransaction>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;

        }
    }
}