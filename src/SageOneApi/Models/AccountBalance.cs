using System.Collections.Generic;

namespace SageOneApi.Models
{
	public class AccountBalance : BaseModel
	{
		public int Type { get; set; }
		public string Date { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public string CategoryDescription { get; set; }
		public int AnalysisCategoryId { get; set; }
		public string AnalysisCategoryDescription { get; set; }
		public decimal Debit { get; set; }
		public decimal Credit { get; set; }
		public decimal Total { get; set; }
		public List<BudgetItemPeriod> BudgetItemPeriods { get; set; }
	}

}