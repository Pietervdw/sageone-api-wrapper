namespace SageOneApi.Models
{
	public class ItemReportGroup : BaseModel
	{
		public string Name { get; set; }
		public int ItemReportingGroupTypeId { get; set; }
		public string ItemReportingGroupType { get; set; }
		public int ReportingGroupId { get; set; }
	}
}