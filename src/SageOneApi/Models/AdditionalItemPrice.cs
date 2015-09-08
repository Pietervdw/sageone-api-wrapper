namespace SageOneApi.Models
{
	public class AdditionalItemPrice : BaseModel
	{
		public int ItemId { get; set; }
		public decimal PriceInclusive { get; set; }
		public decimal PriceExclusive { get; set; }
		public int AdditionalPriceListId { get; set; }
	}
}