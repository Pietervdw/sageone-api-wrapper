namespace SageOneApi.Models
{
	public class Enums
	{
		public enum CategoryType
		{
			Account,
			Asset,
			BankAccount,
			Customer,
			Item,
			Supplier
		}

		public enum CommercialDocumentLineType
		{
			Item = 0,
			Account = 1,
			Time = 3,
			TimeEntry = 4,
			Recharge = 5
		}
	}
}