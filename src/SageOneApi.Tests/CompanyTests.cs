using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SageOneApi.Tests
{
    [TestClass]
    public class CompanyTests : TestBase
    {
        [TestMethod]
        public void GetCurrentCompany()
        {
            var api = new ApiRequest(Username, Password, Apikey, 0);
            var currentCompany = api.CompanyRequest.Current();
        }
    }
}
