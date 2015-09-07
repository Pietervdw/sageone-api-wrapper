using System.Collections.Generic;
using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
	public interface ICategoryRequest
	{
		/// <summary>
		/// Gets a single item category by ID.
		/// </summary>
		/// <param name="id">The ID of the item category.</param>
		/// <param name="categoryType">Type of category e.g Account, Analysis, Asset, BankAccount, Customer, Item, Supplier</param>
		/// <returns>A <see cref="Category"/> object</returns>
		Category Get(int id, Enums.CategoryType categoryType);

		/// <summary>
		/// Gets a collection of item categories.
		/// </summary>
		/// <returns>An List collection of <see cref="Category"/> objects</returns>
		/// <param name="categoryType">Type of category e.g Account, Analysis, Asset, BankAccount, Customer, Item, Supplier</param>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		PagingResponse<Category> Get(Enums.CategoryType categoryType,string filter = "");

		/// <summary>
		/// Saves the specified customer.
		/// </summary>
		/// <param name="category">The item category.</param>
		/// <param name="categoryType">Type of category e.g Account, Analysis, Asset, BankAccount, Customer, Item, Supplier</param>
		/// <returns>A <see cref="Category"/> object, populated with updated/new values</returns>
		Category Save(Category category, Enums.CategoryType categoryType);

		/// <summary>
		/// Deletes an item category
		/// </summary>
		/// <param name="id">The ID of the item category to delete</param>
		/// <param name="categoryType">Type of category e.g Account, Analysis, Asset, BankAccount, Customer, Item, Supplier</param>
		/// <returns>True if successfully deleted, otherwise false</returns>
		bool Delete(int id, Enums.CategoryType categoryType); 
	}
}