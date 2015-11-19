using SageOneApi.Models;
namespace SageOneApi.Interfaces
{
	public interface IAccountNoteRequest
	{
		/// <summary>
		/// Gets a single Account Note by ID.
		/// </summary>
		/// <param name="id">The ID of the account note.</param>
		/// <returns>A <see cref="AccountNote"/> object</returns>
		/// 
		AccountNote Get(int id);

		/// <summary>
		/// Gets a collection of Account Notes.
		/// </summary>
		/// <returns>An List collection of <see cref="AccountNote"/> objects</returns>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		/// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
		PagingResponse<AccountNote> Get(string filter = "", int skip = 0);

		/// <summary>
		/// Saves the specified Account Note.
		/// </summary>
		/// <param name="accountNote">The Account Note.</param>
		/// <returns>A <see cref="AssetNote"/> object, populated with updated/new values</returns>
		AccountNote Save(AccountNote accountNote);

		/// <summary>
		/// Deletes an Asset Note
		/// </summary>
		/// <param name="id">The ID of the Account Note to delete</param>
		/// <returns>True if successfully deleted, otherwise false</returns>
		bool Delete(int id);   
	}
}