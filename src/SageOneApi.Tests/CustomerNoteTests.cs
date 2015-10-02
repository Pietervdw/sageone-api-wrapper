using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class CustomerNoteTests : TestBase
	{
		[TestMethod]
		public void GetAll()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var customerNotes = api.CustomerNoteRequest.Get(filter: "CustomerId eq 0");
		}

		[TestMethod]
		public void Get()
		{
			int customerNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var customerNote = api.CustomerNoteRequest.Get(customerNoteId);
		}

		[TestMethod]
		public void Save()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
		    var customerNote = new CustomerNote
		    {
		        CustomerId = 0,
                NotePriority = 1,
                NoteType = 1,
                Status = true,
                ActionDate = DateTime.Now.ToShortDateString(),
                EntryDate = DateTime.Now.ToShortDateString(),
                HasAttachments = false,
                Subject = "A note about this customer",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at scelerisque tortor. Morbi facilisis vitae nulla a imperdiet. Curabitur molestie rhoncus aliquam. Mauris turpis nibh, lobortis non tincidunt a, ornare eget felis."
            };

		    var newCustomerNote = api.CustomerNoteRequest.Save(customerNote);
		}

		[TestMethod]
		public void Delete()
		{
			int customerNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.CustomerNoteRequest.Delete(customerNoteId);
		}
	}
}
