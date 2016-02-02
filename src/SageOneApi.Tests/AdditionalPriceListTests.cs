using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class AdditionalPriceListTests : TestBase
    {
        [TestMethod]
        public void GetAdditionalPriceLists()
        {
            var pricelists = Api.AdditionalPriceListRequest.Get();
        }

        [TestMethod]
        public void GetAdditionalPriceList()
        {
            var priceListId = 0;
            var pricelist = Api.AdditionalPriceListRequest.Get(priceListId);
        }

        [TestMethod]
        public void CreateAdditionalPriceList()
        {
            var additionalPriceList = new AdditionalPriceList
            {
                Description = "My New Pricelist",
                IsDefault = false
            };
            var newPricelist = Api.AdditionalPriceListRequest.Save(additionalPriceList);
        }

        [TestMethod]
        public void DeleteAdditionalPriceList()
        {
            var priceListId = 0;
            var result = Api.AdditionalPriceListRequest.Delete(priceListId);
        }
    }
}
