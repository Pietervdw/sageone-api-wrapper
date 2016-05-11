using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;
using SageOneApi.Requests;

namespace SageOneApi.Tests
{
    [TestClass]
    public class BankTransactionTests : TestBase
    {
        private BankTransactionRequest bankTransactionRequest;

        [TestInitialize]
        public void LocalInit()
        {
            bankTransactionRequest = Api.BankTransactionRequest; // Api is declared on TestBase
        }

        [TestMethod]
        public void GetBankAllTransactions()
        {
            var transactions = bankTransactionRequest.Get();
        }

        [TestMethod]
        public void GetBankTransaction()
        {
            int transactionId = 0;
            var transaction = bankTransactionRequest.Get(transactionId);
        }

        [TestMethod]
        public void CreateBankTransaction()
        {
            var transaction = new BankTransaction
            {
                Date = DateTime.Now,
                BankAccountId = 0,
                Type = 2,
                SelectionId = 0,
                DocumentNumber = "RCP00000124",
                Payee = "Cash",
                Reference = "012",
                Description = "",
                Total=2000
            };
            var result = bankTransactionRequest.Save(transaction);
        }
    }
}
