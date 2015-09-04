using System;

namespace SageOneApi.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public bool Active { get; set; }
        public float Balance { get; set; }
        public string Description { get; set; }
        public bool UnallocatedAccount { get; set; }
        public bool IsTaxLocked { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public int AccountType { get; set; }
    }
}