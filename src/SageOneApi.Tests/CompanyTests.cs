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
            var currentCompany = Api.CompanyRequest.Current();
        }

        [TestMethod]
        public void GetAllCompanies()
        {
            var api = new ApiRequest(Username, Password, Apikey, 0);
            var allCompanies = Api.CompanyRequest.Get();
        }

        [TestMethod]
        public void GetCompany()
        {
            var api = new ApiRequest(Username, Password, Apikey, 0);
            int companyId = 0;
            var company = Api.CompanyRequest.Get(companyId);
        }
    }
}
