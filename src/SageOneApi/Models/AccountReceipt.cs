using System;

namespace SageOneApi.Models
{
    public class AccountReceipt : BaseModel
    {
        public int AccountId { get; set; }
        public DateTime Date { get; set; }
        public string Payee { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public int TaxTypeId { get; set; }
        public string Comments { get; set; }
        public decimal Exclusive { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public bool Reconciled { get; set; }
        public int BankAccountId { get; set; }
        public int AnalysisCategoryId1 { get; set; }
        public int AnalysisCategoryId2 { get; set; }
        public int AnalysisCategoryId3 { get; set; }
        public int ParentId { get; set; }
        public bool Accepted { get; set; }
        public string BankUniqueIdentifier { get; set; }
        public int ImportTypeId { get; set; }
        public int BankImportMappingId { get; set; }
        public int BankAccountCurrencyId { get; set; }
        public decimal BankAccountExchangeRate { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
    }
    

}