using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface IAdditionalItemPriceRequest
    {

        /// <summary>
        /// Gets a single Additional Item Price by ID.
        /// </summary>
        /// <param name="id">The ID of the Additional Item Price.</param>
        /// <returns>A <see cref="AdditionalItemPrice"/> object</returns>
        AdditionalItemPrice Get(int id);

        /// <summary>
        /// Gets a collection of Additional Item Prices.
        /// </summary>
        /// <returns>An List collection of <see cref="AdditionalItemPrice"/> objects</returns>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<AdditionalItemPrice> Get(string filter = "", int skip = 0);

        /// <summary>
		/// Saves the specified Additional Item Price.
		/// </summary>
		/// <param name="additionalItemPrice">The Additional Item Price.</param>
		/// <returns>A <see cref="AdditionalItemPrice"/> object, populated with updated/new values</returns>
		AdditionalItemPrice Save(AdditionalItemPrice additionalItemPrice);

        /// <summary>
        /// Deletes an Additional Item Price
        /// </summary>
        /// <param name="id">The ID of the Additional Item Price to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}