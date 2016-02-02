using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class AssetLocationTests : TestBase
	{
		[TestMethod]
		public void GetAllAssetLocations()
		{
			var assetLocations = Api.AssetLocationRequest.Get();
		}

		[TestMethod]
		public void GetAssetLocations()
		{
			int assetLocationId = 0;
			var assetLocation = Api.AssetLocationRequest.Get(assetLocationId);
		}

		[TestMethod]
		public void SaveAssetLocation()
		{
			var assetLocation = new AssetLocation();
			assetLocation.Description = "Company HQ";
			var newAssetLocation = Api.AssetLocationRequest.Save(assetLocation);
		}

		[TestMethod]
		public void DeleteAssetLocation()
		{
			int assetLocationId = 0;
			var result = Api.AssetLocationRequest.Delete(assetLocationId);
		}
	}
}
