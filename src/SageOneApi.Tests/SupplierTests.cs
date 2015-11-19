using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class SupplierTests : TestBase
	{
		[TestMethod]
		public void GetAllSuppliers()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var suppliers = api.SupplierRequest.Get();
		}

		[TestMethod]
		public void GetSupplier()
		{
			int supplierId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var supplier = api.SupplierRequest.Get(supplierId);
		}


		[TestMethod]
		public void Save()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var supplier = new Supplier
			{
				Name = "New Orleans Cajun Delights",
				ContactName = "Shelley Burke",
				DeliveryAddress01 = "P.O. Box 78934",
				DeliveryAddress02 = "New Orleans",
				DeliveryAddress03 = "LA",
				DeliveryAddress04 = "70117",
				DeliveryAddress05 = "USA",
				PostalAddress01 = "P.O. Box 78934",
				PostalAddress02 = "New Orleans",
				PostalAddress03 = "LA",
				PostalAddress04 = "70117",
				PostalAddress05 = "USA",
				Telephone = "(100) 555-4822",
                Active = true
            };

			api.SupplierRequest.Save(supplier);
		}

		[TestMethod]
		public void Delete()
		{
			int supplierId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var supplier = api.SupplierRequest.Delete(supplierId);
		}
	}
}
