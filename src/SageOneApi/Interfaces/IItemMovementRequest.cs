using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface IItemMovementRequest
    {
        /// <summary>
        /// Gets a collection of Item Movement transactions
        /// </summary>
        /// <returns>An List collection of <see cref="ItemMovement"/> objects</returns>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<ItemMovement> Get(string filter = "", int skip = 0);
    }
}