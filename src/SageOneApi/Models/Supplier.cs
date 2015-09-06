namespace SageOneApi.Models
{
	public class Supplier : BaseModel
	{
		public string Name { get; set; }
		public Category Category { get; set; }
		public string TaxReference { get; set; }
		public string ContactName { get; set; }
		public string Telephone { get; set; }
		public string Fax { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
		public string WebAddress { get; set; }
		public bool Active { get; set; }
		public decimal Balance { get; set; }
		public decimal CreditLimit { get; set; }
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
		public string TextField1 { get; set; }
		public string TextField2 { get; set; }
		public string TextField3 { get; set; }
		public decimal NumericField1 { get; set; }
		public decimal NumericField2 { get; set; }
		public decimal NumericField3 { get; set; }
		public bool YesNoField1 { get; set; }
		public bool YesNoField2 { get; set; }
		public bool YesNoField3 { get; set; }
		public string DateField1 { get; set; }
		public string DateField2 { get; set; }
		public string DateField3 { get; set; }
		public string Modified { get; set; }
		public string Created { get; set; }
		public string BusinessRegistrationNumber { get; set; }
		public string RMCDApprovalNumber { get; set; }
		public string TaxStatusVerified { get; set; }
		public int CurrencyId { get; set; }
		
	}


}