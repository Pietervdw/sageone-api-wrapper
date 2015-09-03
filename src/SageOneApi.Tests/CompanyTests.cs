using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SageOneApi.Tests
{
    [TestClass]
    public class CompanyTests : TestBase
    {
        [TestMethod]
        public void GetCurrent()
        {
            var api = new ApiRequest(Username, Password, Apikey, 0);
            var currentCompany = api.CompanyRequest.Current();
        }
    }
}
