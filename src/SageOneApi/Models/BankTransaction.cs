using System;
using System.Collections.Generic;

namespace SageOneApi.Models
{
    public class BankTransaction : BaseModel
    {
      public DateTime Date{get; set;}
      public int BankAccountId {get; set;} 
      public int Type{get; set;}
      public int SelectionId{get; set;} 
      public string DocumentNumber{get; set;}
      public string Payee {get; set;} 
      public string Reference {get; set;} 
      public string Description {get; set;} 
      public int TaxTypeId{get; set;} 
      public decimal Exclusive{get; set;} 
      public decimal Tax {get; set;} 
      public decimal Total {get; set;} 
      public decimal Discount {get; set;} 
      public bool Reconciled{get; set;} 
      public string BankUniqueIdentifier {get; set;}
      public int AnalysisCategoryId1 {get; set;} 
      public int AnalysisCategoryId2 {get; set;} 
      public int AnalysisCategoryId3 {get; set;} 
      public string Memo {get; set;} 
      public int BankImportMappingId{get; set;} 
      public int TaxPeriodId{get; set;} 
      public bool Editable{get; set;} 
      public List<BankTransaction> SplitTransactions{get; set;} 
      public bool Accepted {get; set;} 
      public bool Duplicate {get; set;} 
      public bool Matched {get; set;} 
      public string MatchReference{get; set;} 
      public bool Locked{get; set;} 
      public bool HasAttachments{get; set;} 
      public bool HasAllocations {get; set;} 
      public int PaymentMethodId{get; set;} 
      public int ImportTypeId{get; set;} 
      public string TrackingCode{get; set;} 
      public bool Dirty{get; set;} 
      public int BankAccountCurrencyId{get; set;} 
      public decimal BankAccountExchangeRate{get; set;} 
      public int SelectionCurrencyId{get; set;} 
      public decimal SelectionExchangeRate {get; set;} 
      public int TimeAndBillingProjectId{get; set;}
      public int TimeAndBillingExpenseId{get; set;} 
      public int BillingMethodId{get; set;} 
      public decimal Recharge{get; set;} 
      public decimal MarkupPercentage {get; set;}
      public DateTime ImportActionDate{get; set;} 

    }
}
