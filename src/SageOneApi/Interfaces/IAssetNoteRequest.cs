using SageOneApi.Models;
namespace SageOneApi.Interfaces
{
	public interface IAssetNoteRequest
	{
		/// <summary>
		/// Gets a single Asset Note by ID.
		/// </summary>
		/// <param name="id">The ID of the Asset note.</param>
		/// <returns>A <see cref="AssetNote"/> object</returns>
		/// 
		AssetNote Get(int id);

		/// <summary>
		/// Gets a collection of Asset Notes.
		/// </summary>
		/// <returns>An List collection of <see cref="AssetNote"/> objects</returns>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		/// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
		PagingResponse<AssetNote> Get(string filter = "", int skip = 0);

		/// <summary>
		/// Saves the specified Asset Note.
		/// </summary>
		/// <param name="AssetNote">The Asset Note.</param>
		/// <returns>A <see cref="AssetNote"/> object, populated with updated/new values</returns>
		AssetNote Save(AssetNote assetNote);

		/// <summary>
		/// Deletes an Asset Note
		/// </summary>
		/// <param name="id">The ID of the Asset Note to delete</param>
		/// <returns>True if successfully deleted, otherwise false</returns>
		bool Delete(int id);   
	}
}