namespace SageOneApi.Models
{
	public class AccountNote : BaseModel
	{
		public int AccountId { get; set; }
		public string Subject { get; set; }
		public string EntryDate { get; set; }
		public string ActionDate { get; set; }
		public bool Status { get; set; }
		public string Note { get; set; }
		public bool HasAttachments { get; set; }
	}
}