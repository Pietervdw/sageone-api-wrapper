using System;
using RestSharp;
using RestSharp.Authenticators;
using SageOneApi.Requests;

namespace SageOneApi
{
    public class ApiRequest
    {
        private readonly string _apiKey;
        private readonly int _companyId;
        private readonly IRestClient _client;

        public AccountRequest AccountRequest { get { return new AccountRequest(_client, _apiKey, _companyId); } }
		public AccountBalanceRequest AccountBalanceRequest { get { return new AccountBalanceRequest(_client, _apiKey, _companyId); } }
		public AccountNoteRequest AccountNoteRequest { get { return new AccountNoteRequest(_client, _apiKey, _companyId); } }
        public AdditionalPriceListRequest AdditionalPriceListRequest { get { return new AdditionalPriceListRequest(_client, _apiKey, _companyId); } }
        public AdditionalItemPriceRequest AdditionalItemPriceRequest { get { return new AdditionalItemPriceRequest(_client, _apiKey, _companyId); } }
        public AssetRequest AssetRequest { get { return new AssetRequest(_client, _apiKey, _companyId); } }
		public AssetLocationRequest AssetLocationRequest { get { return new AssetLocationRequest(_client, _apiKey, _companyId); } }
		public AssetNoteRequest AssetNoteRequest { get { return new AssetNoteRequest(_client, _apiKey, _companyId); } }
        public BankAccountRequest BankAccountRequest { get { return new BankAccountRequest(_client, _apiKey, _companyId); } }
        public ItemRequest ItemRequest { get { return new ItemRequest(_client, _apiKey, _companyId); } }
        public ItemNoteRequest ItemNoteRequest { get { return new ItemNoteRequest(_client, _apiKey, _companyId); } }
        public CompanyRequest CompanyRequest { get { return new CompanyRequest(_client, _apiKey); } }
        public CustomerRequest CustomerRequest { get { return new CustomerRequest(_client, _apiKey, _companyId); } }
        public CustomerNoteRequest CustomerNoteRequest { get { return new CustomerNoteRequest(_client, _apiKey, _companyId); } }
        public CategoryRequest CategoryRequest { get { return new CategoryRequest(_client, _apiKey, _companyId); } }
        public PurchaseOrderRequest PurchaseOrderRequest { get { return new PurchaseOrderRequest(_client, _apiKey, _companyId); } }
        public SalesRepresentativeRequest SalesRepresentativeRequest { get { return new SalesRepresentativeRequest(_client, _apiKey, _companyId); } }
        public SupplierInvoiceRequest SupplierInvoiceRequest { get { return new SupplierInvoiceRequest(_client, _apiKey, _companyId); } }
        public SupplierRequest SupplierRequest { get { return new SupplierRequest(_client, _apiKey, _companyId); } }
		public TaxInvoiceRequest TaxInvoiceRequest { get { return new TaxInvoiceRequest(_client, _apiKey, _companyId); } }
        public TaxTypeRequest TaxTypeRequest { get { return new TaxTypeRequest(_client, _apiKey, _companyId); } }

        public ApiRequest(string username, string password, string apiKey, int companyId)
        {
            _apiKey = apiKey;
            _companyId = companyId;

            _client = new RestClient
            {
                BaseUrl = new Uri("https://accounting.sageone.co.za/api/1.1.1/"),
                Authenticator = new HttpBasicAuthenticator(username, password)
            };
        }
    }
}
