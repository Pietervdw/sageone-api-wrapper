using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;
using SageOneApi.Requests;

namespace SageOneApi.Tests
{
    [TestClass]
    public class TaxInvoiceTests : TestBase
    {
        private TaxInvoiceRequest taxInvoiceRequest;

        [TestInitialize]
        public void LocalInit()
        {
            taxInvoiceRequest = Api.TaxInvoiceRequest; // Api is declared on TestBase
        }

        [TestMethod]
        public void GetAllTaxInvoices()
        {
            var invoices = taxInvoiceRequest.Get(true, true);
        }


        [TestMethod]
        public void GetTaxInvoice()
        {
            int invoiceId = 0;
            var invoice = taxInvoiceRequest.Get(invoiceId);
        }

        [TestMethod]
        public void CalculateAndSaveTaxInvoice()
        {
            int invoiceId = 0;
            var invoice = taxInvoiceRequest.Get(invoiceId);
            foreach (var line in invoice.Lines)
            {
                line.Quantity = line.Quantity + 1;
            }
            var calculatedInvoice = taxInvoiceRequest.Calculate(invoice);
            var updatedInvoice = taxInvoiceRequest.Save(calculatedInvoice);
        }

        [TestMethod]
        public void CreateTaxInvoice()
        {
            var customerId = 0;
            var salesRepId = 0;

            var itemId = 0;
            var taxTypeId = 0;

            TaxInvoice invoice = new TaxInvoice();
            var customer = Api.CustomerRequest.Get(customerId);
            var salesRep = Api.SalesRepresentativeRequest.Get(salesRepId);

            // Must set both CustomerId and Customer in order to work
            invoice.CustomerId = customerId;
            invoice.Customer = customer;

            // Must set both SalesRepresentativeId and SalesRepresentative in order to work
            invoice.SalesRepresentativeId = salesRepId; 
            invoice.SalesRepresentative = salesRep;

            invoice.Date = DateTime.Now;
            invoice.DueDate = new DateTime(2015, 12, 12);

            invoice.Lines = new List<CommercialDocumentLine>();

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

            invoice.Lines.Add(line1);
            
            var newTaxInvoice = taxInvoiceRequest.Save(invoice);
            Assert.IsTrue(taxInvoiceRequest.StatusCode == HttpStatusCode.Created);
        }

    }
}
