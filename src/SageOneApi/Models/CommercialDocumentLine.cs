namespace SageOneApi.Models
{
	public class CommercialDocumentLine : BaseModel
	{
		public int SelectionId { get; set; }
		public int TaxTypeId { get; set; }
		public string Description { get; set; }
		public Enums.CommercialDocumentLineType LineType { get; set; }
		public decimal Quantity { get; set; }
		public decimal UnitPriceExclusive { get; set; }
		public string Unit { get; set; }
		public decimal UnitPriceInclusive { get; set; }
		public decimal TaxPercentage { get; set; }
		public decimal DiscountPercentage { get; set; }
		public decimal Exclusive { get; set; }
		public decimal Discount { get; set; }
		public decimal Tax { get; set; }
		public decimal Total { get; set; }
		public string Comments { get; set; }
		public int AnalysisCategoryId1 { get; set; }
		public int AnalysisCategoryId2 { get; set; }
		public int AnalysisCategoryId3 { get; set; }
		public string TrackingCode { get; set; }
		public int CurrencyId { get; set; }
		public decimal UnitCost { get; private set; } 
	}
}