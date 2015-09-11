using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class AssetLocationTests : TestBase
	{
		[TestMethod]
		public void GetAll()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var assetLocations = api.AssetLocationRequest.Get();
		}

		[TestMethod]
		public void Get()
		{
			int assetLocationId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var assetLocation = api.AssetLocationRequest.Get(assetLocationId);
		}

		[TestMethod]
		public void Save()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var assetLocation = new AssetLocation();
			assetLocation.Description = "Company HQ";
			var newAssetLocation = api.AssetLocationRequest.Save(assetLocation);
		}

		[TestMethod]
		public void Delete()
		{
			int assetLocationId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.AssetLocationRequest.Delete(assetLocationId);
		}
	}
}
