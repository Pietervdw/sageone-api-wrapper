using System;
using RestSharp.Serializers;

namespace SageOneApi.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CurrencySymbol { get; set; }
        public int CurrencyDecimalDigits { get; set; }
        public int NumberDecimalDigits { get; set; }
        public string DecimalSeparator { get; set; }
        public int HoursDecimalDigits { get; set; }
        public int ItemCostPriceDecimalDigits { get; set; }
        public int ItemSellingPriceDecimalDigits { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddress3 { get; set; }
        public string PostalAddress4 { get; set; }
        public string PostalAddress5 { get; set; }
        public string GroupSeparator { get; set; }
        public int RoundingValue { get; set; }
        public int TaxSystem { get; set; }
        public int RoundingType { get; set; }
        public bool AgeMonthly { get; set; }
        public bool DisplayInactiveItems { get; set; }
        public bool WarnWhenItemCostIsZero { get; set; }
        public bool WarnWhenItemQuantityIsZero { get; set; }
        public bool WarnWhenItemSellingBelowCost { get; set; }
        public int CountryId { get; set; }
        public int CompanyEntityTypeId { get; set; }
        public bool EnableCustomerZone { get; set; }
        public bool EnableAutomaticBankFeedRefresh { get; set; }
        public string ContactName { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool IsPrimarySendingEmail { get; set; }
        public string PostalAddress01 { get; set; }
        public string PostalAddress02 { get; set; }
        public string PostalAddress03 { get; set; }
        public string PostalAddress04 { get; set; }
        public string PostalAddress05 { get; set; }
        public string CompanyInfo01 { get; set; }
        public string CompanyInfo02 { get; set; }
        public string CompanyInfo03 { get; set; }
        public string CompanyInfo04 { get; set; }
        public string CompanyInfo05 { get; set; }
        public bool IsOwner { get; set; }
        public bool UseCCEmail { get; set; }
        public string CCEmail { get; set; }
        public bool CheckForDuplicateCustomerReferences { get; set; }
        public bool CheckForDuplicateSupplierReferences { get; set; }
        public string DisplayName { get; set; }
        public bool DisplayInactiveCustomers { get; set; }
        public bool DisplayInactiveSuppliers { get; set; }
        public bool DisplayInactiveTimeProjects { get; set; }
        public bool LockProcessing { get; set; }
        public bool LockTimesheetProcessing { get; set; }
        public int TaxPeriodFrequency { get; set; }
        public bool UseNoreplyEmail { get; set; }
        public bool AgeingBasedOnDueDate { get; set; }
        public bool UseLogoOnEmails { get; set; }
        public bool UseLogoOnCustomerZone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int HomeCurrencyId { get; set; }
        public int CurrencyId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Active { get; set; }
    }
}