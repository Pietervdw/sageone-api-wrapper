using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class ItemTests : TestBase
    {
        [TestMethod]
        public void GetAllItems()
        {
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var items = api.ItemRequest.Get();
        }

        [TestMethod]
        public void GetItem()
        {
            int itemId = 0;
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var item = api.ItemRequest.Get(itemId);
        }

        [TestMethod]
        public void SaveItem()
        {
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var item = new Item
            {
                Code = "AAA",
                Description = "AAA battery",
                Active = true,
                Physical = true
            };
            api.ItemRequest.Save(item);
        }

        [TestMethod]
        public void DeleteItem()
        {
            int itemId = 0;
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var result = api.ItemRequest.Delete(itemId);
        }
    }
}
