using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class SalesRepresentativeTests : TestBase
	{
		[TestMethod]
		public void GetAll()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var salesReps = api.SalesRepresentativeRequest.Get();
		}

		[TestMethod]
		public void Get()
		{
			int customerId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var salesRep = api.SalesRepresentativeRequest.Get(customerId);
		}

		[TestMethod]
		public void Save()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var salesRep = new SalesRepresentative
			{
				FirstName = "Nancy",
				LastName = "Davolio",
				Email = "nancy@northwindtraders.com",
				Mobile = "(206) 555-9857",
				Telephone = "(206) 555-9857"
			};

			api.SalesRepresentativeRequest.Save(salesRep);
		}

		[TestMethod]
		public void Delete()
		{
			int customerId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.SalesRepresentativeRequest.Delete(customerId);
		}

		[TestMethod]
		public void HasActivity()
		{
			int customerId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.SalesRepresentativeRequest.HasActivity(customerId);
		}
	}
}
