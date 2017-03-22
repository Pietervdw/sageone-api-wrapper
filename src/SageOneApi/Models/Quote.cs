using System;
using System.Collections.Generic;

namespace SageOneApi.Models
{
    //
    public class Quote : BaseModel
    {
        public DateTime ExpiryDate { get; set; }
        public bool AllowOnlineAccept { get; set; }
        public bool UseForeignCurrency { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Customer Customer { get; set; }
        public int SalesRepresentativeId { get; set; }
        public SalesRepresentative SalesRepresentative { get; set; }
        public int StatusId { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public DateTime Date { get; set; }
        public bool Inclusive { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string TaxReference { get; set; }
        public string DocumentNumber { get; set; }
        public string Reference { get; set; }
        public string Message { get; set; }
        public decimal Discount { get; set; }
        public decimal Exclusive { get; set; }
        public decimal Tax { get; set; }
        public decimal Rounding { get; set; }
        public decimal Total { get; set; }
        public decimal AmountDue { get; set; }
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
        public bool Printed { get; set; }
        public int CurrencyId { get; set; }
        public decimal ExchangeRate { get; set; }
        public int TaxPeriodId { get; set; }
        public bool Editable { get; set; }
        public bool HasAttachments { get; set; }
        public bool HasNotes { get; set; }
        public bool HasAnticipatedDate { get; set; }
        public DateTime AnticipatedDate { get; set; }
        public string ExternalReference { get; set; }
        public List<CommercialDocumentLine> Lines { get; set; }
    }
    
}