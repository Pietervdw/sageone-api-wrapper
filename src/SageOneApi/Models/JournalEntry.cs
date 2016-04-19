using System;

namespace SageOneApi.Models
{
    public class JournalEntry : BaseModel
    {
        public DateTime Date { get; set; }
        public Enums.EffectType Effect { get; set; } //Gets or sets the Journal Entry. Debit = 1, Credit = 2
        public int AccountId { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public int TaxTypeId { get; set; }
        public decimal Exclusive { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public int ContraAccountId { get; set; }
        public string Memo { get; set; }
        public bool HasAttachments { get; set; }
        public int AnalysisCategoryId1 { get; set; }
        public int AnalysisCategoryId2 { get; set; }
        public int AnalysisCategoryId3 { get; set; }
    }
}