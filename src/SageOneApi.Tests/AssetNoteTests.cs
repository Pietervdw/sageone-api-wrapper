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
			var assetNotes = Api.AssetNoteRequest.Get();
		}

		[TestMethod]
		public void GetAssetNote()
		{
			int assetNoteId = 0;
			var assetNote = Api.AssetNoteRequest.Get(assetNoteId);
		}

		[TestMethod]
		public void SaveAssetNote()
		{
			var assetNote = new AssetNote
			{
				AssetId = 0,
				ActionDate = DateTime.Now,
				EntryDate = DateTime.Now,
				Status=true,
				Subject = "A new note about this asset",
				Note="A Note Here."
			};
			var newAssetNote = Api.AssetNoteRequest.Save(assetNote);
		}

		[TestMethod]
		public void DeleteAssetNote()
		{
			int assetNoteId = 0;
			var result = Api.AssetNoteRequest.Delete(assetNoteId);
		}
	}
}
