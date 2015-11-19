using System;
using System.Collections.Generic;

namespace SageOneApi.Models
{
	public class TaxInvoice : BaseModel
	{
		public DateTime DueDate { get; set; }
		public string FromDocument { get; set; }
		public int FromDocumentId { get; private set; }
		public int FromDocumentTypeId { get; private set; }
		public bool AllowOnlinePayment { get; set; }
		public bool Paid { get; private set; }
		public string Status { get; private set; }
		public bool Locked { get; private set; }
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
		public Customer Customer { get; set; }
		public int SalesRepresentativeId { get; set; }
		public SalesRepresentative SalesRepresentative { get; set; }
		public int StatusId { get; set; }
		public DateTime Modified { get; private set; }
		public DateTime Created { get; private set; }
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
		public int TaxPeriodId { get; private set; }
		public bool Editable { get; private set; }
		public bool HasAttachments { get; private set; }
		public bool HasNotes { get; private set; }
		public bool HasAnticipatedDate { get; private set; }
		public DateTime AnticipatedDate { get; private set; }
		public List<CommercialDocumentLine> Lines { get; set; }
	}

}