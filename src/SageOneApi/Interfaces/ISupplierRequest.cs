using System.Collections.Generic;
using System.Threading.Tasks;
using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
	public interface ISupplierRequest
	{
		/// <summary>
		/// Gets a single supplier by ID.
		/// </summary>
		/// <param name="id">The ID of the supplier.</param>
		/// <returns>A <see cref="Supplier"/> object</returns>
		/// 
		Supplier Get(int id);

		/// <summary>
		/// Gets a collection of suppliers.
		/// </summary>
		/// <returns>An List collection of <see cref="Supplier"/> objects</returns>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		/// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
		PagingResponse<Supplier> Get(string filter = "", int skip = 0);

        /// <summary>
        /// Gets a collection of suppliers asynchronously.
        /// </summary>
        /// <returns>An List collection of <see cref="Supplier"/> objects</returns>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        Task<PagingResponse<Supplier>> GetAsync(string filter = "", int skip = 0);

        /// <summary>
        /// Saves the specified supplier.
        /// </summary>
        /// <param name="supplier">The supplier.</param>
        /// <returns>A <see cref="Supplier"/> object, populated with updated/new values</returns>
        Supplier Save(Supplier supplier);

        /// <summary>
        /// Saves the specified supplier asynchronously.
        /// </summary>
        /// <param name="supplier">The supplier.</param>
        /// <returns>A <see cref="Supplier"/> object, populated with updated/new values</returns>
        Task<Supplier> SaveAsync(Supplier supplier);

        /// <summary>
        /// Deletes a supplier
        /// </summary>
        /// <param name="id">The ID of the supplier to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
	}
}