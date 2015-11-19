namespace SageOneApi.Models
{
    public class BankAccount : BaseModel
    {
        public string Name { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string BranchNumber { get; set; }
        public Category Category { get; set; }
        public bool Active { get; set; }
        public bool Default { get; set; }
        public float Balance { get; set; }
        public string Description { get; set; }
        public string LastTransactionDate { get; set; }
        public string LastImportDate { get; set; }
        public bool HasTransactionsWaitingForReview { get; set; }
        public Enums.PaymentMethod DefaultPaymentMethodId { get; set; }
        public Enums.PaymentMethod PaymentMethod { get; set; }
        public string Modified { get; set; }
        public string Created { get; set; }
        public int CurrencyId { get; set; }
    }

}