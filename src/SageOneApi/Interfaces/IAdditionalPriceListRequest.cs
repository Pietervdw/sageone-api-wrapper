using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface IAdditionalPriceListRequest
    {
        /// <summary>
        /// Gets a single Additional Price List by ID.
        /// </summary>
        /// <param name="id">The ID of the Additional Price List.</param>
        /// <returns>A <see cref="AdditionalPriceList"/> object</returns>
        /// 
        AdditionalPriceList Get(int id);

        /// <summary>
        /// Gets a collection of Additional Price Lists.
        /// </summary>
        /// <returns>An List collection of <see cref="AdditionalPriceList"/> objects</returns>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<AdditionalPriceList> Get(string filter = "", int skip = 0);

        /// <summary>
        /// Saves the specified Additional Price List.
        /// </summary>
        /// <param name="pricelist">The Additional Price List item.</param>
        /// <returns>A <see cref="AdditionalPriceList"/> object, populated with updated/new values</returns>
        AdditionalPriceList Save(AdditionalPriceList pricelist);

        /// <summary>
        /// Deletes an Additional Price List
        /// </summary>
        /// <param name="id">The ID of the Additional Price List to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}