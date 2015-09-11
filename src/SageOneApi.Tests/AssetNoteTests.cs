using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class AssetNoteTests : TestBase
	{
		[TestMethod]
		public void GetAll()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var assetNotes = api.AssetNoteRequest.Get();
		}

		[TestMethod]
		public void Get()
		{
			int assetNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var assetNote = api.AssetNoteRequest.Get(assetNoteId);
		}

		[TestMethod]
		public void Save()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var assetNote = new AssetNote
			{
				AssetId = 0,
				ActionDate = DateTime.Now.ToShortDateString(),
				EntryDate = DateTime.Now.ToShortDateString(),
				Status=true,
				Subject = "A new note about this asset",
				Note="A Note Here."
			};
			var newAssetNote = api.AssetNoteRequest.Save(assetNote);
		}

		[TestMethod]
		public void Delete()
		{
			int assetNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.AssetNoteRequest.Delete(assetNoteId);
		}
	}
}
