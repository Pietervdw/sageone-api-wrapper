using System;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class SupplierInvoiceRequest: RequestBase, ISupplierInvoiceRequest
    {
        public SupplierInvoiceRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

        public SupplierInvoice Get(int id)
        {
            var response = _client.Execute<SupplierInvoice>(new RestRequest(String.Format("SupplierInvoice/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public PagingResponse<SupplierInvoice> Get(bool includeDetail = false, bool includeSupplierDetails = false, string filter = "", int skip = 0)
        {
            var url = string.Format("SupplierInvoice/Get?companyid={0}&includeDetail={1}&includeSupplierDetails={2}&apikey={3}", _companyId, includeDetail.ToString().ToLower(), includeSupplierDetails.ToString().ToLower(), _apiKey);

            if (!string.IsNullOrEmpty(filter))
                url = string.Format("SupplierInvoice/Get?includeDetail={0}&includeSupplierDetails={1}?apikey={2}&companyid={3}&$filter={4}", includeDetail, includeSupplierDetails, _apiKey, _companyId, filter);

            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return deserializer.Deserialize<PagingResponse<SupplierInvoice>>(response);
        }

        public SupplierInvoice Save(SupplierInvoice invoice)
        {
            var url = string.Format("SupplierInvoice/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(invoice);
            var response = _client.Execute<SupplierInvoice>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public SupplierInvoice Calculate(SupplierInvoice invoice)
        {
            var url = string.Format("SupplierInvoice/Calculate?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(invoice);
            var response = _client.Execute<SupplierInvoice>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }
    }
}