using System;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
    public class PurchaseOrderRequest : RequestBase, IPurchaseOrderRequest
    {
        public PurchaseOrderRequest(IRestClient client, string apiKey, int companyId) : base(client, apiKey, companyId) { }

        public PurchaseOrder Get(int id)
        {
            var response = _client.Execute<PurchaseOrder>(new RestRequest(string.Format("PurchaseOrder/Get/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId), Method.GET));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public PagingResponse<PurchaseOrder> Get(bool includeDetail = false, bool includeSupplierDetails = false, string filter = "", int skip = 0)
        {
            var url = string.Format("PurchaseOrder/Get?companyid={0}&includeDetail={1}&includeSupplierDetails={2}&apikey={3}", _companyId, includeDetail.ToString().ToLower(), includeSupplierDetails.ToString().ToLower(), _apiKey);

            if (!string.IsNullOrEmpty(filter))
                url = string.Format("PurchaseOrder/Get?includeDetail={0}&includeSupplierDetails={1}?apikey={2}&companyid={3}&$filter={4}", includeDetail, includeSupplierDetails, _apiKey, _companyId, filter);

            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return deserializer.Deserialize<PagingResponse<PurchaseOrder>>(response);
        }

        public PurchaseOrder Save(PurchaseOrder purchaseOrder)
        {
            var url = string.Format("PurchaseOrder/Save?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(purchaseOrder);
            var response = _client.Execute<PurchaseOrder>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public PurchaseOrder Calculate(PurchaseOrder purchaseOrder)
        {
            var url = string.Format("PurchaseOrder/Calculate?apikey={0}&companyid={1}", _apiKey, _companyId);
            var request = new RestRequest(url, Method.POST) { JsonSerializer = new JsonSerializer() };
            request.RequestFormat = DataFormat.Json;
            request.AddBody(purchaseOrder);
            var response = _client.Execute<PurchaseOrder>(request);
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }

        public bool Delete(int id)
        {
            var url = string.Format("PurchaseOrder/Delete/{0}?apikey={1}&companyid={2}", id, _apiKey, _companyId);
            var response = _client.Execute<PurchaseOrder>(new RestRequest(url, Method.DELETE));
            return response.ResponseStatus == ResponseStatus.Completed;
        }
    }
}