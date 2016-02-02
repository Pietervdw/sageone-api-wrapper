using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class SalesRepresentativeTests : TestBase
	{
		[TestMethod]
		public void GetAllSalesRepresentatives()
		{
			var salesReps = Api.SalesRepresentativeRequest.Get();
		}

		[TestMethod]
		public void GetSalesRepresentative()
		{
			int customerId = 0;
			var salesRep = Api.SalesRepresentativeRequest.Get(customerId);
		}

		[TestMethod]
		public void SaveSalesRepresentative()
		{
			var salesRep = new SalesRepresentative
			{
				FirstName = "Nancy",
				LastName = "Davolio",
				Email = "nancy@northwindtraders.com",
				Mobile = "(206) 555-9857",
				Telephone = "(206) 555-9857"
			};

            Api.SalesRepresentativeRequest.Save(salesRep);
		}

		[TestMethod]
		public void DeleteSalesRepresentative()
		{
			int customerId = 0;
			var result = Api.SalesRepresentativeRequest.Delete(customerId);
		}

		[TestMethod]
		public void HasActivity_SalesRepresentative()
		{
			int customerId = 0;
			var result = Api.SalesRepresentativeRequest.HasActivity(customerId);
		}
	}
}
