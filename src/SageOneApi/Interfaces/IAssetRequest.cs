using SageOneApi.Models;
namespace SageOneApi.Interfaces
{
	public interface IAssetRequest
	{
		/// <summary>
		/// Gets a single Asset by ID.
		/// </summary>
		/// <param name="id">The ID of the Asset.</param>
		/// <returns>A <see cref="Asset"/> object</returns>
		/// 
		Asset Get(int id);

		/// <summary>
		/// Gets a collection of Assets.
		/// </summary>
		/// <returns>An List collection of <see cref="Asset"/> objects</returns>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		/// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
		PagingResponse<Asset> Get(string filter = "", int skip = 0);

		/// <summary>
		/// Saves the specified Asset.
		/// </summary>
		/// <param name="asset">The Asset.</param>
		/// <returns>A <see cref="Asset"/> object, populated with updated/new values</returns>
		Asset Save(Asset asset);

		/// <summary>
		/// Deletes a Asset
		/// </summary>
		/// <param name="id">The ID of the Asset to delete</param>
		/// <returns>True if successfully deleted, otherwise false</returns>
		bool Delete(int id); 
	}
}