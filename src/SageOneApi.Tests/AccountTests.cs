using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class AccountTests : TestBase
    {
        [TestMethod]
        public void GetAll()
        {
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var accounts = api.AccountRequest.Get(true);
        }

        [TestMethod]
        public void GetAllByCategory()
        {
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var accounts = api.AccountRequest.GetByCategory(1);
        }

        [TestMethod]
        public void Get()
        {
            int accountId = 0;
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var account = api.AccountRequest.Get(accountId);
        }


        [TestMethod]
        public void Save()
        {
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var account = new Account();
            account.Name = "Other Other Sales";
            account.AccountType = 5;
            account.Category = new Category {ID = 1};

            var newaccount = api.AccountRequest.Save(account);
        }


        [TestMethod]
        public void Delete()
        {
            int accountId = 0;
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var result = api.AccountRequest.Delete(accountId);
        }
    }
}