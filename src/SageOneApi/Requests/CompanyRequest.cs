using RestSharp;
using RestSharp.Deserializers;
using SageOneApi.Interfaces;
using SageOneApi.Models;

namespace SageOneApi.Requests
{
	public class CompanyRequest : RequestBase, ICompanyRequest
	{
		public CompanyRequest(IRestClient client, string apiKey) : base(client, apiKey) { }

		public PagingResponse<Company> Current()
		{
			var url = string.Format("Company/Get?apikey={0}", _apiKey);
			var request = new RestRequest(url, Method.GET);
			request.RequestFormat = DataFormat.Json;

			var response = _client.Execute(request);
			JsonDeserializer deserializer = new JsonDeserializer();
			return deserializer.Deserialize<PagingResponse<Company>>(response);
		}

	    public PagingResponse<Company> Get(string filter = "", int skip = 0)
	    {
            var url = string.Format("Company/Get?apikey={0}", _apiKey);

            if (!string.IsNullOrEmpty(filter))
                url = string.Format("Company/Get?apikey={0}&$filter={1}", _apiKey, filter);

            if (skip > 0)
                url += "&$skip=" + skip;

            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = _client.Execute(request);
            JsonDeserializer deserializer = new JsonDeserializer();

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return deserializer.Deserialize<PagingResponse<Company>>(response);
        }

	    public Company Get(int id)
	    {
            var response = _client.Execute<Company>(new RestRequest(string.Format("Company/Get/{0}?apikey={1}", id, _apiKey), Method.GET));
            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;
            return response.Data;
        }
	}
}