using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface ISupplierInvoiceRequest
    {
        /// <summary>
		/// Gets a single supplier invoice by ID.
		/// </summary>
		/// <param name="id">The ID of the tax invoice.</param>
		/// <returns>A <see cref="SupplierInvoice"/> object</returns>
		/// 
		SupplierInvoice Get(int id);

        /// <summary>
        /// Gets a collection of supplier invoices.
        /// </summary>
        /// <param name="includeDetail">if set to <c>true</c> include the lines.</param>
        /// <param name="includeSupplierDetails">if set to <c>true</c> the Supplier is included.</param>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        /// <returns></returns>
        PagingResponse<SupplierInvoice> Get(bool includeDetail = false, bool includeSupplierDetails = false, string filter = "", int skip = 0);

        /// <summary>
        /// Saves the specified supplier invoice.
        /// </summary>
        /// <param name="invoice">The supplier invoice.</param>
        /// <returns>A <see cref="SupplierInvoice"/> object, populated with updated/new values</returns>
        SupplierInvoice Save(SupplierInvoice invoice);

        /// <summary>
        /// Calculates the specified supplier invoice total fields
        /// </summary>
        /// <param name="invoice">The supplier invoice.</param>
        /// <returns>A <see cref="SupplierInvoice"/> object, populated with updated total fields.</returns>
        SupplierInvoice Calculate(SupplierInvoice invoice);
    }
}