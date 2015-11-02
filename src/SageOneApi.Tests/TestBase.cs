using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SageOneApi.Tests
{
    [TestClass]
    public class TestBase
    {
        private string _username = "[YourUsername]";
        private string _password = "[YourPassword]";
        private string _apikey = "[YourAPIKey]";
        private int _companyId = 0;
        public ApiRequest Api;

        public string Username
        {
            get { return _username; }
        }

        public string Password
        {
            get { return _password; }
        }

        public string Apikey
        {
            get { return _apikey; }
        }

        public int CompanyId
        {
            get { return _companyId; }
        }

        [TestInitialize]
        public void Init()
        {
            Api = new ApiRequest(_username, _password, _apikey, _companyId);
        }
    }
}