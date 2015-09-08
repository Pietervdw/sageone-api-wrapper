namespace SageOneApi.Models
{
	public class TaxType : BaseModel
	{
		public string Name { get; set; }
		public decimal Percentage { get; set; }
		public bool IsDefault { get; set; }
		public bool HasActivity { get; set; }
		public bool IsManualTax { get; set; }
		public string Created { get; set; }
		public string Modified { get; set; }
	}
}