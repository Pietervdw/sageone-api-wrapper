using System.Collections.Generic;
using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
	public interface IItemCategoryRequest
	{
		/// <summary>
		/// Gets a single item category by ID.
		/// </summary>
		/// <param name="id">The ID of the item category.</param>
		/// <returns>A <see cref="ItemCategory"/> object</returns>
		/// 
		ItemCategory Get(int id);

		/// <summary>
		/// Gets a collection of item categories.
		/// </summary>
		/// <returns>An List collection of <see cref="ItemCategory"/> objects</returns>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		PagingResponse<List<ItemCategory>> Get(string filter = "");

		/// <summary>
		/// Saves the specified customer.
		/// </summary>
		/// <param name="category">The item category.</param>
		/// <returns>A <see cref="Customer"/> object, populated with updated/new values</returns>
		ItemCategory Save(ItemCategory category);

		/// <summary>
		/// Deletes an item category
		/// </summary>
		/// <param name="id">The ID of the item category to delete</param>
		/// <returns>True if successfully deleted, otherwise false</returns>
		bool Delete(int id); 
	}
}