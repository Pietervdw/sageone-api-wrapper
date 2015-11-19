using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;
using SageOneApi.Requests;

namespace SageOneApi.Tests
{
    [TestClass]
    public class TaxTypeTests : TestBase
    {
        private TaxTypeRequest taxTypeRequest;

        [TestInitialize]
        public void LocalInit()
        {
            taxTypeRequest = Api.TaxTypeRequest; // Api is declared on TestBase
        }

        [TestMethod]
        public void GetAllTaxTypes()
        {
            var taxTypes = taxTypeRequest.Get();
        }

        [TestMethod]
        public void GetTaxType()
        {
            var taxTypeId = 1272654;
            var taxType = taxTypeRequest.Get(taxTypeId);
        }

        [TestMethod]
        public void SaveTaxType()
        {
            var taxType = new TaxType
            {
                Name = "New Tax Type",
                Percentage = 0.20m
            };
            var newTaxType = taxTypeRequest.Save(taxType);
        }

        [TestMethod]
        public void DeleteTaxType()
        {
            var taxTypeId = 1356512;
            taxTypeRequest.Delete(taxTypeId);
        }
    }
}
