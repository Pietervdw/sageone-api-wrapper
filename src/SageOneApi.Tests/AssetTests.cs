using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class AssetTests : TestBase
	{
		[TestMethod]
		public void GetAllAssets()
		{
			var assets = Api.AssetRequest.Get();
		}

		[TestMethod]
		public void GetAsset()
		{
			int assetId = 0;
			var asset = Api.AssetRequest.Get(assetId);
		}

		[TestMethod]
		public void SaveAsset()
		{
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
			var newAsset = Api.AssetRequest.Save(asset);

		}

		[TestMethod]
		public void DeleteAsset()
		{
			int assetId = 0;
			var result = Api.AssetRequest.Delete(assetId);
		}
	}
}
