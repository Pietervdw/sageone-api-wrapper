namespace SageOneApi.Models
{
    public class BankFeedAccount : BaseModel
    {
        public int BankFeedAccountGroupId { get; set; }
        public BankFeedAccountGroup BankFeedAccountGroup { get; set; }
        public string Description { get; set; }
        public string Identifier { get; set; }
        public string LastRefreshDate { get; set; }
        public string FirstImportDate { get; set; }
        public float Balance { get; set; }
        public int BankAccountId { get; set; }
        public string BankAccountName { get; set; }
        public int LastRefreshStatusId { get; set; }
    }
}