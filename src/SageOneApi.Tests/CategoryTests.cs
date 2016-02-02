using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class CategoryTests : TestBase
    {
        #region Account Categories

        [TestMethod]
        public void GetAll_AccountCategory()
        {
            var categories = Api.CategoryRequest.Get(Enums.CategoryType.Account);
        }

        [TestMethod]
        public void Get_AccountCategory()
        {
            int categoryId = 0; var category = Api.CategoryRequest.Get(categoryId, Enums.CategoryType.Account);
        }


        #endregion

        #region Asset Categories

        [TestMethod]
        public void GetAll_AssetCategory()
        {
            var categories = Api.CategoryRequest.Get(Enums.CategoryType.Asset);
        }

        [TestMethod]
        public void Get_AssetCategory()
        {
            int categoryId = 0;
            var category = Api.CategoryRequest.Get(categoryId, Enums.CategoryType.Asset);
        }

        [TestMethod]
        public void Save_AssetCategory()
        {
            var itemCategory = new Category();
            itemCategory.Description = "Asset Category Test";
            var newCategory = Api.CategoryRequest.Save(itemCategory, Enums.CategoryType.Asset);
        }

        [TestMethod]
        public void Delete_AssetCategory()
        {
            int categoryId = 0;
            var result = Api.CategoryRequest.Delete(categoryId, Enums.CategoryType.Asset);
        }

        #endregion

        #region BankAccount Categories

        [TestMethod]
        public void GetAll_BankAccountCategory()
        {
            var categories = Api.CategoryRequest.Get(Enums.CategoryType.BankAccount);
        }

        [TestMethod]
        public void Get_BankAccountCategory()
        {
            int categoryId = 0;
            var category = Api.CategoryRequest.Get(categoryId, Enums.CategoryType.BankAccount);
        }

        [TestMethod]
        public void Save_BankAccountCategory()
        {
            var itemCategory = new Category();
            itemCategory.Description = "BankAccount Category Test";
            var newCategory = Api.CategoryRequest.Save(itemCategory, Enums.CategoryType.BankAccount);
        }

        [TestMethod]
        public void Delete_BankAccountCategory()
        {
            int categoryId = 0;
            var result = Api.CategoryRequest.Delete(categoryId, Enums.CategoryType.BankAccount);
        }

        #endregion

        #region Customer Categories

        [TestMethod]
        public void GetAll_CustomerCategory()
        {
            var categories = Api.CategoryRequest.Get(Enums.CategoryType.Customer);
        }

        [TestMethod]
        public void Get_CustomerCategory()
        {
            int categoryId = 0;
            var category = Api.CategoryRequest.Get(categoryId, Enums.CategoryType.Customer);
        }

        [TestMethod]
        public void Save_CustomerCategory()
        {
            var itemCategory = new Category();
            itemCategory.Description = "Customer Category Test";
            var newCategory = Api.CategoryRequest.Save(itemCategory, Enums.CategoryType.Customer);
        }

        [TestMethod]
        public void Delete_CustomerCategory()
        {
            int categoryId = 0;
            var result = Api.CategoryRequest.Delete(categoryId, Enums.CategoryType.Customer);
        }

        #endregion

        #region Item Categories

        [TestMethod]
        public void GetAll_ItemCategory()
        {
            var categories = Api.CategoryRequest.Get(Enums.CategoryType.Item);
        }

        [TestMethod]
        public void Get_ItemCategory()
        {
            int categoryId = 0;
            var category = Api.CategoryRequest.Get(categoryId, Enums.CategoryType.Item);
        }

        [TestMethod]
        public void Save_ItemCategory()
        {
            var itemCategory = new Category();
            itemCategory.Description = "Accessories";
            var newCategory = Api.CategoryRequest.Save(itemCategory, Enums.CategoryType.Item);
        }

        [TestMethod]
        public void Delete_ItemCategory()
        {
            int categoryId = 0;
            var result = Api.CategoryRequest.Delete(categoryId, Enums.CategoryType.Item);
        }

        #endregion

        #region Supplier Categories

        [TestMethod]
        public void GetAll_SupplierCategory()
        {
            var categories = Api.CategoryRequest.Get(Enums.CategoryType.Supplier);
        }

        [TestMethod]
        public void Get_SupplierCategory()
        {
            int categoryId = 0;
            var category = Api.CategoryRequest.Get(categoryId, Enums.CategoryType.Supplier);
        }

        [TestMethod]
        public void Save_SupplierCategory()
        {
            var category = new Category();
            category.Description = "Supplier Category - Test";
            var newCategory = Api.CategoryRequest.Save(category, Enums.CategoryType.Supplier);
        }

        [TestMethod]
        public void Delete_SupplierCategory()
        {
            int categoryId = 0;
            var result = Api.CategoryRequest.Delete(categoryId, Enums.CategoryType.Supplier);
        }

        #endregion

    }
}
