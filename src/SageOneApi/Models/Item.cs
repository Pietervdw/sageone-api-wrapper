using System;

namespace SageOneApi.Models
{
	public class Item : BaseModel
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }
        public decimal PriceInclusive { get; set; }
        public decimal PriceExclusive { get; set; }
        public bool Physical { get; set; }
        public decimal LastCost { get; set; }
        public decimal AverageCost { get; set; }
        public decimal QuantityOnHand { get; set; }
        public DateTime Modified { get; set; }
        public string ItemReportingGroupPurchasesName { get; set; }
        public string ItemReportingGroupSalesName { get; set; }
    }

}