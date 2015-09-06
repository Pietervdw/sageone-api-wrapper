using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class ItemCategoryTests :TestBase
	{
		[TestMethod]
		public void GetAll()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var itemCategories = api.ItemCategoryRequest.Get();
		}

		[TestMethod]
		public void Get()
		{
			int categoryId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var itemCategory = api.ItemCategoryRequest.Get(categoryId);
		}

		[TestMethod]
		public void Save()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var itemCategory = new ItemCategory();
			itemCategory.Description = "Components";
			var newIteCategory = api.ItemCategoryRequest.Save(itemCategory);
		}

		[TestMethod]
		public void Delete()
		{
			int categoryId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.ItemCategoryRequest.Delete(categoryId);
		}
	}
}
