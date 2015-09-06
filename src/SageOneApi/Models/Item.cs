using System;

namespace SageOneApi.Models
{
	public class Item : BaseModel
	{
		public string Description { get; set; }
		public Category Category { get; set; }
		public string Code { get; set; }
		public bool Active { get; set; }
		public decimal PriceInclusive { get; set; }
		public decimal PriceExclusive { get; set; }
		public bool Physical { get; set; }
		public int TaxTypeIdSales { get; set; }
		public TaxType TaxTypeSales { get; set; }
		public int TaxTypeIdPurchases { get; set; }
		public TaxType TaxTypePurchases { get; set; }
		public decimal LastCost { get; set; }
		public decimal AverageCost { get; set; }
		public decimal QuantityOnHand { get; set; }
		public bool HasAttachments { get; set; }
		public string Unit { get; set; }
		public int? ItemReportingGroupId_Sales { get; set; }
		public ItemReportGroup ItemReportingGroupSales { get; set; }
		public int? ItemReportingGroupId_Purchases { get; set; }
		public ItemReportGroup ItemReportingGroupPurchases { get; set; }
		public string TextUserField1 { get; set; }
		public string TextUserField2 { get; set; }
		public string TextUserField3 { get; set; }
		public float NumericUserField1 { get; set; }
		public float NumericUserField2 { get; set; }
		public float NumericUserField3 { get; set; }
		public string DateUserField1 { get; set; }
		public string DateUserField2 { get; set; }
		public string DateUserField3 { get; set; }
		public bool YesNoUserField1 { get; set; }
		public bool YesNoUserField2 { get; set; }
		public bool YesNoUserField3 { get; set; }
		public string Modified { get; set; }
		public int MajorIndustryCodeId { get; set; }
		public decimal GPPercentage { get; set; }
		public decimal GPAmount { get; set; }
		public string ItemReportingGroupPurchasesName { get; set; }
		public string ItemReportingGroupSalesName { get; set; }
		public AdditionalItemPrice[] AdditionalItemPrices { get; set; }
	}
}