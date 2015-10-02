using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface ICustomerNoteRequest
    {
        /// <summary>
        /// Gets a single Customer Note by ID.
        /// </summary>
        /// <param name="id">The ID of the Customer note.</param>
        /// <returns>A <see cref="CustomerNote"/> object</returns>
        /// 
        CustomerNote Get(int id);

        /// <summary>
        /// Gets a collection of Customer Notes.
        /// </summary>
        /// <returns>An List collection of <see cref="AssetNote"/> objects</returns>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<CustomerNote> Get(string filter = "", int skip = 0);

        /// <summary>
        /// Saves the specified Customer Note.
        /// </summary>
        /// <param name="customerNote">The Customer Note.</param>
        /// <returns>A <see cref="AssetNote"/> object, populated with updated/new values</returns>
        CustomerNote Save(CustomerNote customerNote);

        /// <summary>
        /// Deletes an Customer Note
        /// </summary>
        /// <param name="id">The ID of the Customer Note to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}