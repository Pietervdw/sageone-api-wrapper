using System.Collections.Generic;

namespace SageOneApi.Models
{
	public class EmailRequest : BaseModel
	{
		public string EmailAddress { get; set; }
		public string CCAddress { get; set; }
		public string BCCAddress { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
		public List<Attachment> Attachments { get; set; }
	}


}