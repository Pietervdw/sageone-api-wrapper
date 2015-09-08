using System;

namespace SageOneApi.Models
{
	public class Account : BaseModel
    {

		public string Name { get; set; }
        public Category Category { get; set; }
        public bool Active { get; set; }
		public decimal Balance { get; private set; }
        public string Description { get; set; }
		public bool UnallocatedAccount { get; private set; }
		public bool IsTaxLocked { get; private set; }
		public DateTime Modified { get; private set; }
		public DateTime Created { get; private set; }
		public int AccountType { get; private set; }
    }
}