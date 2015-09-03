using RestSharp.Serializers;

namespace SageOneApi.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int SalesRepresentativeId { get; set; }
        public SalesRepresentative SalesRepresentative { get; set; }
        public string TaxReference { get; set; }
        public string ContactName { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string WebAddress { get; set; }
        public bool Active { get; set; }
        public float Balance { get; set; }
        public float CreditLimit { get; set; }
        public int CommunicationMethod { get; set; }
        public string PostalAddress01 { get; set; }
        public string PostalAddress02 { get; set; }
        public string PostalAddress03 { get; set; }
        public string PostalAddress04 { get; set; }
        public string PostalAddress05 { get; set; }
        public string DeliveryAddress01 { get; set; }
        public string DeliveryAddress02 { get; set; }
        public string DeliveryAddress03 { get; set; }
        public string DeliveryAddress04 { get; set; }
        public string DeliveryAddress05 { get; set; }
        public bool AutoAllocateToOldestInvoice { get; set; }
        public bool EnableCustomerZone { get; set; }
        public string CustomerZoneGuid { get; set; }
        public bool CashSale { get; set; }
        public string TextField1 { get; set; }
        public string TextField2 { get; set; }
        public string TextField3 { get; set; }
        public float NumericField1 { get; set; }
        public float NumericField2 { get; set; }
        public float NumericField3 { get; set; }
        public bool YesNoField1 { get; set; }
        public bool YesNoField2 { get; set; }
        public bool YesNoField3 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public int DefaultPriceListId { get; set; }
        public DefaultPricelist DefaultPriceList { get; set; }
        public string DefaultPriceListName { get; set; }
        public bool AcceptsElectronicInvoices { get; set; }
        public string Modified { get; set; }
        public string Created { get; set; }
        public string BusinessRegistrationNumber { get; set; }
        public string TaxStatusVerified { get; set; }
        public int CurrencyId { get; set; }
  
    }
}