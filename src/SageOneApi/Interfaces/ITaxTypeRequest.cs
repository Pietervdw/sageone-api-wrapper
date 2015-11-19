using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface ITaxTypeRequest
    {
        /// <summary>
        /// Gets a single Tax Type by ID.
        /// </summary>
        /// <param name="id">The ID of the Tax Type.</param>
        /// <returns>A <see cref="TaxType"/> object</returns>
        /// 
        TaxType Get(int id);

        /// <summary>
        /// Gets a collection of tax types.
        /// </summary>
        /// <returns>An List collection of <see cref="TaxType"/> objects</returns>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<TaxType> Get(string filter = "", int skip = 0);


        /// <summary>
        /// Saves the specified Tax Type.
        /// </summary>
        /// <param name="taxType">The Tax Type.</param>
        /// <returns>A <see cref="TaxType"/> object, populated with updated/new values</returns>
        TaxType Save(TaxType taxType);

        /// <summary>
        /// Deletes a Tax Type
        /// </summary>
        /// <param name="id">The ID of the Tax Type to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}