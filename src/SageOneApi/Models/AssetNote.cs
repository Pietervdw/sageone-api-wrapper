using System;

namespace SageOneApi.Models
{
	public class AssetNote : BaseModel
	{
		public int AssetId { get; set; }
		public string Subject { get; set; }
		public DateTime EntryDate { get; set; }
		public DateTime ActionDate { get; set; }
		public bool Status { get; set; }
		public string Note { get; set; }
		public bool HasAttachments { get; set; }
	}

}