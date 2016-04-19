namespace SageOneApi.Interfaces
{
    public interface IJournalEntryRequest
    {
        /// <summary>
        /// Gets a single journal entry by ID.
        /// </summary>
        /// <param name="id">The ID of the purchase.</param>
        /// <returns>A <see cref="Models.JournalEntry"/> object</returns>
        Models.JournalEntry Get(int id);

        ///// <summary>
        ///// Gets a collection of journal entrys.
        ///// </summary>
        ///// <param name="includeDetail">if set to <c>true</c> include the lines.</param>
        ///// <param name="includeSupplierDetails">if set to <c>true</c> the Supplier is included.</param>
        ///// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        ///// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        ///// <returns></returns>
        //PagingResponse<JournalEntry> Get(bool includeDetail = false, bool includeSupplierDetails = false, string filter = "", int skip = 0);

        /// <summary>
        /// Saves the specified journal entry.
        /// </summary>
        /// <param name="JournalEntry">The journal entry.</param>
        /// <returns>A <see cref="JournalEntry"/> object, populated with updated/new values</returns>
        Models.JournalEntry Save(Models.JournalEntry JournalEntry);

        /// <summary>
        /// Calculates the specified journal entry total fields
        /// </summary>
        /// <param name="JournalEntry">The journal entry.</param>
        /// <returns>A <see cref="JournalEntry"/> object, populated with updated total fields.</returns>
        Models.JournalEntry Calculate(Models.JournalEntry JournalEntry);

        /// <summary>
        /// Deletes a journal entry
        /// </summary>
        /// <param name="id">The ID of the journal entry to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);

    }
}