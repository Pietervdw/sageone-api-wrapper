namespace SageOneApi.Models
{
	public class Asset : BaseModel
	{
		public string Description { get; set; }
		public Category Category { get; set; }
		public AssetLocation Location { get; set; }
		public string DatePurchased { get; set; }
		public string SerialNumber { get; set; }
		public string BoughtFrom { get; set; }
		public float PurchasePrice { get; set; }
		public float CurrentValue { get; set; }
		public float ReplacementValue { get; set; }
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
	}

}