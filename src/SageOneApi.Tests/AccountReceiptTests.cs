using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class AccountReceiptTests : TestBase
    {
        [TestMethod]
        public void GetAllAccountReceipts()
        {
            var accountReceipts = Api.AccountReceiptRequest.Get();
        }

        [TestMethod]
        public void SaveAccounReceipt()
        {
            var accountReceipt = new AccountReceipt
            {
                AccountId = 0,
                Date = DateTime.Now,
                Payee = "Joe Blogs",
                Description = "Payment to Joe Blogs",
                TaxTypeId = 0,
                Exclusive = 50,
                BankAccountId = 0
            };

            var newaccountReceipt = Api.AccountReceiptRequest.Save(accountReceipt);
        }
    }
}