using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface IItemNoteRequest
    {
        /// <summary>
        /// Gets a single Item Note by ID.
        /// </summary>
        /// <param name="id">The ID of the Item note.</param>
        /// <returns>A <see cref="ItemNote"/> object</returns>
        /// 
        ItemNote Get(int id);

        /// <summary>
        /// Gets a collection of Item Notes.
        /// </summary>
        /// <returns>An List collection of <see cref="AssetNote"/> objects</returns>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<ItemNote> Get(string filter = "", int skip = 0);

        /// <summary>
        /// Saves the specified Asset Note.
        /// </summary>
        /// <param name="itemNote">The Asset Note.</param>
        /// <returns>A <see cref="ItemNote"/> object, populated with updated/new values</returns>
        ItemNote Save(ItemNote itemNote);

        /// <summary>
        /// Deletes an Item Note
        /// </summary>
        /// <param name="id">The ID of the Asset Note to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}