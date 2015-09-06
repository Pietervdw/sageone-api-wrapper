using System;

namespace SageOneApi.Models
{
	public class ItemCategory : BaseModel
	{
		public string Description { get; set; }
		public DateTime Modified { get; set; }
		public DateTime Created { get; set; }
	}
}