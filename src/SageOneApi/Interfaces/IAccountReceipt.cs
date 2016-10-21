using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface IAccountReceipt
    {
        /// <summary>
        /// Gets a collection of account receipts.
        /// </summary>
        /// <returns>An List collection of <see cref="Account"/> objects</returns>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<AccountReceipt> Get(int skip = 0);


        /// <summary>
        /// Saves the specified account receipt.
        /// </summary>
        /// <param name="accountReceipt">The account receipt.</param>
        /// <returns>A <see cref="AccountReceipt"/> object, populated with updated/new values</returns>
        AccountReceipt Save(AccountReceipt accountReceipt);
    }
}