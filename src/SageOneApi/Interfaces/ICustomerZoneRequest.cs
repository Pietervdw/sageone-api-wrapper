namespace SageOneApi.Interfaces
{
    //
    public interface ICustomerZoneRequest
    {

        /// <summary>
        /// Gets the Customer Zone URL of a specified Invoice
        /// </summary>
        /// <param name="invoiceId">The invoice id.</param>
        /// <param name="customerId">The customer id.</param>
        /// <returns></returns>
        string GetCustomerZoneInvoiceUrl(int invoiceId, int customerId);

        /// <summary>
        /// Gets the Customer Zone URL of a specified Invoice
        /// </summary>
        /// <param name="quoteId">The quote id.</param>
        /// <param name="customerId">The customer id.</param>
        /// <returns></returns>
        string GetCustomerZoneQuoteUrl(int quoteId, int customerId);



    }
}