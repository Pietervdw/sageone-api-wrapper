using System;
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

	}
}
