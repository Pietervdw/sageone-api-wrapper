using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class AccountTests : TestBase
    {
        [TestMethod]
        public void GetAllAccounts()
        {
            var accounts = Api.AccountRequest.Get(true);
        }

        [TestMethod]
        public void GetAllAccountsByCategory()
        {
            var accounts = Api.AccountRequest.GetByCategory(1);
        }

        [TestMethod]
        public void GetAccount()
        {
            int accountId = 0;
            var account = Api.AccountRequest.Get(accountId);
        }

        [TestMethod]
        public void SaveAccount()
        {
            var account = new Account();
            account.Name = "Other Other Sales 1";
            account.Category = new Category { ID = 1 };

            var newaccount = Api.AccountRequest.Save(account);
        }

        [TestMethod]
        public void DeleteAccount()
        {
            int accountId = 7769427;
            var result = Api.AccountRequest.Delete(accountId);
        }
    }
}