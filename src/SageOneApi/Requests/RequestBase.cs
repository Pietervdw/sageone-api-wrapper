using RestSharp;

namespace SageOneApi.Requests
{
	public class RequestBase
	{
		protected readonly IRestClient _client;
		protected readonly string _apiKey;
		protected readonly int _companyId;
		
		public RequestBase() { }

		public RequestBase(IRestClient client, string apiKey)
		{
			_client = client;
			_apiKey = apiKey;
		}

		public RequestBase(IRestClient client, string apiKey, int companyId)
		{
			_client = client;
			_apiKey = apiKey;
			_companyId = companyId;
		}
	}
}