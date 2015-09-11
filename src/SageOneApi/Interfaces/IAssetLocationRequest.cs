using SageOneApi.Models;
namespace SageOneApi.Interfaces
{
	public interface IAssetLocationLocationRequest
	{
		/// <summary>
		/// Gets a single Asset Location by ID.
		/// </summary>
		/// <param name="id">The ID of the Asset Location.</param>
		/// <returns>A <see cref="AssetLocation"/> object</returns>
		/// 
		AssetLocation Get(int id);

		/// <summary>
		/// Gets a collection of Asset Locations.
		/// </summary>
		/// <returns>An List collection of <see cref="AssetLocation"/> objects</returns>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		/// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
		PagingResponse<AssetLocation> Get(string filter = "", int skip = 0);

		/// <summary>
		/// Saves the specified Asset Location.
		/// </summary>
		/// <param name="AssetLocation">The Asset Location.</param>
		/// <returns>A <see cref="AssetLocation"/> object, populated with updated/new values</returns>
		AssetLocation Save(AssetLocation AssetLocation);

		/// <summary>
		/// Deletes an Asset Location
		/// </summary>
		/// <param name="id">The ID of the Asset Location to delete</param>
		/// <returns>True if successfully deleted, otherwise false</returns>
		bool Delete(int id);  
	}
}