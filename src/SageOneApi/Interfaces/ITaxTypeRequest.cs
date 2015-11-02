using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface ITaxTypeRequest
    {
        /// <summary>
        /// Gets a collection of accounts.
        /// </summary>
        /// <returns>An List collection of <see cref="Account"/> objects</returns>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<TaxType> Get(int skip = 0);
    }
}