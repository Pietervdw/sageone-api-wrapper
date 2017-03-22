using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;
using SageOneApi.Requests;

namespace SageOneApi.Tests
{
    [TestClass]
    public class QuoteTests : TestBase
    {
        private QuoteRequest quoteRequest;

        [TestInitialize]
        public void LocalInit()
        {
            quoteRequest = Api.QuoteRequest; // Api is declared on TestBase
        }

        [TestMethod]
        public void GetAllTaxInvoices()
        {
            var quotes = quoteRequest.Get(true, true);
        }


        [TestMethod]
        public void GetTaxInvoice()
        {
            int quoteId = 0;
            var quote = quoteRequest.Get(quoteId);
        }

        [TestMethod]
        public void CalculateAndSaveQuote()
        {
            int quoteId = 0;
            var quote = quoteRequest.Get(quoteId);
            quote.SalesRepresentativeId = 0;

            foreach (var line in quote.Lines)
            {
                line.Quantity = line.Quantity + 1;
            }
            var calculatedQuote = quoteRequest.Calculate(quote);
            var updatedQuote = quoteRequest.Save(calculatedQuote);
        }

        [TestMethod]
        public void CreateQuote()
        {
            var customerId = 0;
            var salesRepId = 0;

            var itemId = 0;
            var taxTypeId = 0;

            Quote quote = new Quote();
            var customer = Api.CustomerRequest.Get(customerId);
            var salesRep = Api.SalesRepresentativeRequest.Get(salesRepId);

            // Must set both CustomerId and Customer in order to work
            quote.CustomerId = customerId;
            quote.Customer = customer;

            // Must set both SalesRepresentativeId and SalesRepresentative in order to work
            quote.SalesRepresentativeId = salesRepId;
            quote.SalesRepresentative = salesRep;

            quote.Date = DateTime.Now;
            quote.ExpiryDate = new DateTime(2016, 12, 12);

            quote.Lines = new List<CommercialDocumentLine>();

            var line1 = new CommercialDocumentLine
            {
                SelectionId = itemId, // This must be an item or account id
                TaxTypeId = taxTypeId, // Use TaxTypeRequest to get list of Tax Types
                LineType = 0, // 0=Item/1=Account
                Quantity = 70,
                UnitPriceExclusive = 390,
                UnitPriceInclusive = 390,
                DiscountPercentage = 0
            };

            quote.Lines.Add(line1);

            var newQuote = quoteRequest.Save(quote);
            Assert.IsTrue(quoteRequest.StatusCode == HttpStatusCode.Created);
        }

        [TestMethod]
        public void EmailQuote()
        {
            var mailRequest = new EmailRequest
            {
                ID = 0,
                EmailAddress = "you@example.com",
                CCAddress = "",
                BCCAddress = "",
                Subject = "Your Quote",
                Message = "Your Quote is attached"
            };
            var result = quoteRequest.Email(mailRequest);
        }

    }
}
