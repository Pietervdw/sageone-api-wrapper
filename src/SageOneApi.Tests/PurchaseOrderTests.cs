using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;
using SageOneApi.Requests;

namespace SageOneApi.Tests
{
    [TestClass]
    public class PurchaseOrderTests : TestBase
    {
        private PurchaseOrderRequest purchaseOrderRequest;

        [TestInitialize]
        public void LocalInit()
        {
            purchaseOrderRequest = Api.PurchaseOrderRequest; // Api is declared on TestBase
        }

        [TestMethod]
        public void GetAllPurchaseOrders()
        {
            var purchaseOrders = purchaseOrderRequest.Get(true, true);
        }

        [TestMethod]
        public void GetPurchaseOrder()
        {
            int poId = 0;
            var purchaseOrder = purchaseOrderRequest.Get(poId);
        }

        [TestMethod]
        public void CreatePurchaseOrder()
        {
            var supplierId = 0;
            var itemId = 0;
            var taxTypeId = 0; 

            PurchaseOrder po = new PurchaseOrder();
            var supplier = Api.SupplierRequest.Get(supplierId);

            po.SupplierId = supplierId;
            po.SupplierName = supplier.Name;
            po.Date = DateTime.Now;
            po.DeliveryDate = DateTime.Now.AddDays(7);

            po.Lines = new List<CommercialDocumentLine>();
            var line1 = new CommercialDocumentLine
            {
                SelectionId = itemId, // This must be an item or account id
                TaxTypeId = taxTypeId, // Use TaxTypeRequest to get list of Tax Types
                LineType = 0, // 0=Item/1=Account
                Quantity = 1,
                UnitPriceExclusive = 390,
                UnitPriceInclusive = 390,
                DiscountPercentage = 0
            };

            po.Lines.Add(line1);

            var newPurchaseOrder = purchaseOrderRequest.Save(po);
            Assert.IsTrue(purchaseOrderRequest.StatusCode == HttpStatusCode.Created);
        }

        [TestMethod]
        public void CalculateAndSavePurchaseOrder()
        {
            int poId = 0;
            var purchaseOrder = purchaseOrderRequest.Get(poId);
            foreach (var line in purchaseOrder.Lines)
            {
                line.Quantity = line.Quantity + 1;
            }
            var calculatedPo = purchaseOrderRequest.Calculate(purchaseOrder);
            var updatedPo = purchaseOrderRequest.Save(calculatedPo);
        }

        [TestMethod]
        public void DeletePurchaseOrder()
        {
            int poId = 0;
            var result = purchaseOrderRequest.Delete(poId);
        }
    }
}