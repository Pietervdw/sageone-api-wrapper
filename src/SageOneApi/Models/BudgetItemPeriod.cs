namespace SageOneApi.Models
{
	public class BudgetItemPeriod : BaseModel
	{
		public string Date { get; set; }
		public decimal Total { get; set; }
	}
}