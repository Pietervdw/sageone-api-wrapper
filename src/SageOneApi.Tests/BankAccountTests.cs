using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;
using SageOneApi.Requests;

namespace SageOneApi.Tests
{
    [TestClass]
    public class BankAccountTests : TestBase
    {
        private BankAccountRequest bankAccountRequest;

        [TestInitialize]
        public void LocalInit()
        {
            bankAccountRequest = Api.BankAccountRequest; // Api is declared on TestBase
        }

        [TestMethod]
        public void GetAllBankAccounts()
        {
            var bankAccounts = bankAccountRequest.Get();
        }

        [TestMethod]
        public void GetBankAccount()
        {
            var bankId = 0;
            var bank = bankAccountRequest.Get(bankId);
        }

        [TestMethod]
        public void SaveBankAccount()
        {
            var bankAccount = new BankAccount
            {
                AccountNumber = "123456789",
                Name = "New Bank Account",
                Active = true,
                Balance = 1000,
                BankName = "Bank Inc.",
                BranchName = "Branch Y",
                BranchNumber = "9988",
                DefaultPaymentMethodId = Enums.PaymentMethod.Cash
            };

            var newBankAccount = bankAccountRequest.Save(bankAccount);
        }

        [TestMethod]
        public void DeleteBankAccount()
        {
            var bankId = 0;
            bankAccountRequest.Delete(bankId);
        }
    }
}
