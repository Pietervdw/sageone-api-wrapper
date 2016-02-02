using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class AdditionalItemPriceTests : TestBase
    {
        [TestMethod]
        public void GetAdditionalItemPrices()
        {
            //var additionalItemPricesWithODataFilter = api.AdditionalItemPriceRequest.Get("ItemId eq 1234567 and AdditionalPriceListId eq 12345");
            var additionalItemPrices = Api.AdditionalItemPriceRequest.Get();
        }

        [TestMethod]
        public void GetAdditionalItemPrice()
        {
            var additionalItemPriceId = 0;
            var additionalItemPrice = Api.AdditionalItemPriceRequest.Get(additionalItemPriceId);
        }

        [TestMethod]
        public void CreateAdditionalItemPrice()
        {
            var additionalItemPrice = new AdditionalItemPrice
            {
                AdditionalPriceListId = 0,
                ItemId = 0,
                PriceExclusive = 200,
                PriceInclusive = 200
            };
            var newAdditionalItemPrice = Api.AdditionalItemPriceRequest.Save(additionalItemPrice);
        }

        [TestMethod]
        public void DeleteAdditionalItemPrice()
        {
            var additionalItemPriceId = 0;
            var result = Api.AdditionalItemPriceRequest.Delete(additionalItemPriceId);
        }

    }
}
