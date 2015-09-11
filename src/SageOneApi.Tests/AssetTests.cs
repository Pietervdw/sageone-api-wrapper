using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class AssetTests : TestBase
	{
		[TestMethod]
		public void GetAll()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var assets = api.AssetRequest.Get();
		}

		[TestMethod]
		public void Get()
		{
			int assetId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var asset = api.AssetRequest.Get(assetId);
		}

		[TestMethod]
		public void Save()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var asset = new Asset
			{
				Description = "Highback chair",
				DatePurchased = DateTime.Now.ToShortDateString(),
				SerialNumber = "12345CH",
				BoughtFrom = "ABC Furniture",
				PurchasePrice = 5000,
				ReplacementValue = 3000,
				CurrentValue = 4000
			};
			var newAsset = api.AssetRequest.Save(asset);

		}

		[TestMethod]
		public void Delete()
		{
			int assetId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.AssetRequest.Delete(assetId);
		}
	}
}
