using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class CustomerNoteTests : TestBase
	{
		[TestMethod]
		public void GetAllCustomerNotes()
		{
			var customerNotes = Api.CustomerNoteRequest.Get(filter: "CustomerId eq 0");
		}

		[TestMethod]
		public void GetCustomerNote()
		{
			int customerNoteId = 0;
			var customerNote = Api.CustomerNoteRequest.Get(customerNoteId);
		}

		[TestMethod]
		public void SaveCustomerNote()
		{
			var customerNote = new CustomerNote
		    {
		        CustomerId = 0,
                NotePriority = 1,
                NoteType = 1,
                Status = true,
                ActionDate = DateTime.Now,
                EntryDate = DateTime.Now,
                HasAttachments = false,
                Subject = "A note about this customer",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at scelerisque tortor. Morbi facilisis vitae nulla a imperdiet. Curabitur molestie rhoncus aliquam. Mauris turpis nibh, lobortis non tincidunt a, ornare eget felis."
            };

		    var newCustomerNote = Api.CustomerNoteRequest.Save(customerNote);
		}

		[TestMethod]
		public void DeleteCustomerNote()
		{
			int customerNoteId = 0;
			var result = Api.CustomerNoteRequest.Delete(customerNoteId);
		}
	}
}
