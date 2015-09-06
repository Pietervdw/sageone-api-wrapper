using System;

namespace SageOneApi.Models
{
	public class Account : BaseModel
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public bool Active { get; set; }
		public decimal Balance { get; set; }
        public string Description { get; set; }
        public bool UnallocatedAccount { get; set; }
        public bool IsTaxLocked { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public int AccountType { get; set; }
    }
}