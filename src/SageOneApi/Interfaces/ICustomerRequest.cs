using System.Collections.Generic;
using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface ICustomerRequest
    {
        /// <summary>
        /// Gets a single customer by ID.
        /// </summary>
        /// <param name="id">The ID of the customer.</param>
        /// <returns>A <see cref="Customer"/> object</returns>
        /// 
        Customer Get(int id);

	    /// <summary>
	    /// Gets a collection of customers.
	    /// </summary>
	    /// <returns>An List collection of <see cref="Customer"/> objects</returns>
	    /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
	    /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
	    PagingResponse<Customer> Get(string filter = "",int skip=0);

        /// <summary>
        /// Saves the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns>A <see cref="Customer"/> object, populated with updated/new values</returns>
        Customer Save(Customer customer);

        /// <summary>
        /// Deletes a customer
        /// </summary>
        /// <param name="id">The ID of the customer to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}