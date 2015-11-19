namespace SageOneApi.Models
{
    public class BankFeedAccountGroup : BaseModel
    {
        public int BankFeedProviderId { get; set; }
        public int BankFeedProviderTypeId { get; set; }
        public string Description { get; set; }
        public string Identifier { get; set; }
        public bool RequiresAdditionalAuthentication { get; set; }
        public int LastRefreshStatusId { get; set; }
    }
}