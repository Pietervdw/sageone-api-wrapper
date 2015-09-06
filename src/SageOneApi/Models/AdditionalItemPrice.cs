namespace SageOneApi.Models
{
	public class AdditionalItemPrice : BaseModel
	{
		public int ItemId { get; set; }
		public float PriceInclusive { get; set; }
		public float PriceExclusive { get; set; }
		public int AdditionalPriceListId { get; set; }
	}
}