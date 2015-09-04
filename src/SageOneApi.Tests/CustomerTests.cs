using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class CustomerTests : TestBase
    {
        [TestMethod]
        public void GetAll()
        {
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var customers = api.CustomerRequest.Get();
        }

        [TestMethod]
        public void Get()
        {
            int customerId = 0;
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var customer = api.CustomerRequest.Get(customerId);
        }

        [TestMethod]
        public void Save()
        {
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var customer = new Customer
            {
                Name = "Contoso Ltd",
                CommunicationMethod = 1
            };
            api.CustomerRequest.Save(customer);
        }

        [TestMethod]
        public void Delete()
        {
            int customerId = 0;
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var result = api.CustomerRequest.Delete(customerId);
        }
    }
}
