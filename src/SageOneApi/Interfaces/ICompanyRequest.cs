using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface ICompanyRequest
    {
        /// <summary>
        /// Retrieves the current Company.
        /// </summary>
        /// <returns>A <see cref="Company"/> object</returns>
        PagingResponse<Company> Current();

        /// <summary>
        /// Gets a collection of Companies.
        /// </summary>
        /// <returns>An List collection of <see cref="Company"/> objects</returns>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<Company> Get(string filter = "", int skip = 0);

        /// <summary>
        /// Gets a single Company  by ID.
        /// </summary>
        /// <param name="id">The ID of the company.</param>
        /// <returns>A <see cref="Company"/> object</returns>
        Company Get(int id);
    }
}