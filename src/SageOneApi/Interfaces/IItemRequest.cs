using System.Collections.Generic;
using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
	public interface IItemRequest
	{
		/// <summary>
		/// Gets a single item by ID.
		/// </summary>
		/// <param name="id">The ID of the item.</param>
		/// <returns>A <see cref="Item"/> object</returns>
		/// 
		Item Get(int id);

		/// <summary>
		/// Gets a collection of items.
		/// </summary>
		/// <returns>An List collection of <see cref="Item"/> objects</returns>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		/// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
		PagingResponse<Item> Get(string filter = "", int skip = 0);

		/// <summary>
		/// Saves the specified item.
		/// </summary>
		/// <param name="item">The Item.</param>
		/// <returns>A <see cref="Item"/> object, populated with updated/new values</returns>
		Item Save(Item item);

		/// <summary>
		/// Deletes an item
		/// </summary>
		/// <param name="id">The ID of the item to delete</param>
		/// <returns>True if successfully deleted, otherwise false</returns>
		bool Delete(int id);
	}
}