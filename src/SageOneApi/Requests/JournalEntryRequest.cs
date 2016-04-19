using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class JournalEntryRequest : RequestBase, IJournalEntryRequest
    {
        public JournalEntryRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

        public JournalEntry Get(int id)
        {
            var response = _client.Execute<JournalEntry>(new RestRequest(string.Format("JournalEntry/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public PagingResponse<JournalEntry> Get(bool includeDetail = false, bool includeSupplierDetails = false, string filter = "", int skip = 0)
        {
            var url = string.Format("JournalEntry/Get?companyid={0}&includeDetail={1}&includeSupplierDetails={2}&apikey={3}", _companyId, includeDetail.ToString().ToLower(), includeSupplierDetails.ToString().ToLower(), _apiKey);

            if (!string.IsNullOrEmpty(filter))
                url += string.Format("&$filter={0}", filter);

            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return deserializer.Deserialize<PagingResponse<JournalEntry>>(response);
        }

        public JournalEntry Save(JournalEntry journalEntry)
        {
            var url = string.Format("JournalEntry/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(journalEntry);
            var response = _client.Execute<JournalEntry>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public JournalEntry Calculate(JournalEntry journalEntry)
        {
            var url = string.Format("JournalEntry/Calculate?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(journalEntry);
            var response = _client.Execute<JournalEntry>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public bool Delete(int id)
        {
            var url = string.Format("JournalEntry/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
            var response = _client.Execute<JournalEntry>(new RestRequest(url, Method.DELETE));
            return response.ResponseStatus == ResponseStatus.Completed;
        }

        //TODO: Implement SaveBatch Method
    }
}