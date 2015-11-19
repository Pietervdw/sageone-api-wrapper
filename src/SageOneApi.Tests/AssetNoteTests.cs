using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class AssetNoteTests : TestBase
	{
		[TestMethod]
		public void GetAllAssetNotes()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var assetNotes = api.AssetNoteRequest.Get();
		}

		[TestMethod]
		public void GetAssetNote()
		{
			int assetNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var assetNote = api.AssetNoteRequest.Get(assetNoteId);
		}

		[TestMethod]
		public void SaveAssetNote()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var assetNote = new AssetNote
			{
				AssetId = 0,
				ActionDate = DateTime.Now,
				EntryDate = DateTime.Now,
				Status=true,
				Subject = "A new note about this asset",
				Note="A Note Here."
			};
			var newAssetNote = api.AssetNoteRequest.Save(assetNote);
		}

		[TestMethod]
		public void DeleteAssetNote()
		{
			int assetNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.AssetNoteRequest.Delete(assetNoteId);
		}
	}
}
