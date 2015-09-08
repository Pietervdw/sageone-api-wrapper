namespace SageOneApi.Models
{
	public class Category : BaseModel
	{
		public string Description { get; set; }
		public string Modified { get; private set; }
		public string Created { get; private set; } 
	}
}