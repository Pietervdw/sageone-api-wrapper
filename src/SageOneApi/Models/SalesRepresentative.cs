namespace SageOneApi.Models
{
	public class SalesRepresentative : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
		public string Name { get; private set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
		public string Created { get; private set; }
		public string Modified { get; private set; } 
    }
}