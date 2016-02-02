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
            var items = Api.ItemRequest.Get();
        }

        [TestMethod]
        public void GetItem()
        {
            int itemId = 0;
            var item = Api.ItemRequest.Get(itemId);
        }

        [TestMethod]
        public void SaveItem()
        {
            var item = new Item
            {
                Code = "AAA",
                Description = "AAA battery",
                Active = true,
                Physical = true
            };
            Api.ItemRequest.Save(item);
        }

        [TestMethod]
        public void DeleteItem()
        {
            int itemId = 0;
            var result = Api.ItemRequest.Delete(itemId);
        }
    }
}
