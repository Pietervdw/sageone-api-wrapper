namespace SageOneApi.Models
{
	public class SalesRepresentative : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string Created { get; set; }
        public string Modified { get; set; } 
    }
}