using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface IPurchaseOrderRequest
    {
        /// <summary>
        /// Gets a single purchase order by ID.
        /// </summary>
        /// <param name="id">The ID of the purchase.</param>
        /// <returns>A <see cref="PurchaseOrder"/> object</returns>
        PurchaseOrder Get(int id);

        /// <summary>
        /// Gets a collection of purchase orders.
        /// </summary>
        /// <param name="includeDetail">if set to <c>true</c> include the lines.</param>
        /// <param name="includeSupplierDetails">if set to <c>true</c> the Supplier is included.</param>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        /// <returns></returns>
        PagingResponse<PurchaseOrder> Get(bool includeDetail = false, bool includeSupplierDetails = false, string filter = "", int skip = 0);

        /// <summary>
        /// Saves the specified purchase order.
        /// </summary>
        /// <param name="purchaseOrder">The purchase order.</param>
        /// <returns>A <see cref="PurchaseOrder"/> object, populated with updated/new values</returns>
        PurchaseOrder Save(PurchaseOrder purchaseOrder);

        /// <summary>
        /// Calculates the specified purchase order total fields
        /// </summary>
        /// <param name="purchaseOrder">The purchase order.</param>
        /// <returns>A <see cref="PurchaseOrder"/> object, populated with updated total fields.</returns>
        PurchaseOrder Calculate(PurchaseOrder purchaseOrder);

        /// <summary>
        /// Deletes a purchase order
        /// </summary>
        /// <param name="id">The ID of the purchase order to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);

    }
}