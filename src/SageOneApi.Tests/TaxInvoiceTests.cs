using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class TaxInvoiceTests : TestBase
    {
        [TestMethod]
        public void GetAll()
        {
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var invoices = api.TaxInvoiceRequest.Get(true, true);
        }


        [TestMethod]
        public void Get()
        {
            int invoiceId = 0;
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var invoice = api.TaxInvoiceRequest.Get(invoiceId);
        }

        [TestMethod]
        public void CalculateAndSave()
        {
            int invoiceId = 0;
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var invoice = api.TaxInvoiceRequest.Get(invoiceId);
            foreach (var line in invoice.Lines)
            {
                line.Quantity = line.Quantity + 1;
            }
            var calculatedInvoice = api.TaxInvoiceRequest.Calculate(invoice);
            var updatedInvoice = api.TaxInvoiceRequest.Save(calculatedInvoice);
        }

        [TestMethod]
        public void Create()
        {
            var api = new ApiRequest(Username, Password, Apikey, CompanyId);
            var customerId = 0;
            var salesRepId = 0;

            var itemId = 0;
            var taxTypeId = 0;

            TaxInvoice invoice = new TaxInvoice();
            var customer = api.CustomerRequest.Get(customerId);
            var salesRep = api.SalesRepresentativeRequest.Get(salesRepId);

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

            var newTaxInvoice = api.TaxInvoiceRequest.Save(invoice);
        }

    }
}
