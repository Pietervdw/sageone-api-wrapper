using RestSharp;
using RestSharp.Serializers;
using SageOneApi.Models;
namespace SageOneApi.Interfaces
{
    public interface IBankTransactionRequest
    {
        /// <summary>
        /// Gets a single Bank Transaction by ID.
        /// </summary>
        /// <param name="id">The ID of the Asset.</param>
        /// <returns>A <see cref="BankTransaction"/> object</returns>
        BankTransaction Get(int id);

        /// <summary>
        /// Gets a collection of Bank Transactions.
        /// </summary>
        /// <returns>An List collection of <see cref="BankTransaction"/> objects</returns>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<BankTransaction> Get(string filter = "", int skip = 0);

        /// <summary>
        /// Saves the specified Bank Transaction.
        /// </summary>
        /// <param name="bankTransaction">The Bank Transaction.</param>
        /// <returns>A <see cref="BankTransaction"/> object, populated with updated/new values</returns>
        BankTransaction Save(BankTransaction bankTransaction);

    }

}