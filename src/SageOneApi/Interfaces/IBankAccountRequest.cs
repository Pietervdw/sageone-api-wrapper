using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface IBankAccountRequest
    {
        /// <summary>
        /// Gets a single Bank Account  by ID.
        /// </summary>
        /// <param name="id">The ID of the bank account.</param>
        /// <returns>A <see cref="BankAccount"/> object</returns>
        BankAccount Get(int id);

        /// <summary>
        /// Gets a collection of Bank Accounts.
        /// </summary>
        /// <returns>An List collection of <see cref="BankAccount"/> objects</returns>
        /// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
        /// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
        PagingResponse<BankAccount> Get(string filter = "", int skip = 0);

        /// <summary>
        /// Saves the specified Bank Account.
        /// </summary>
        /// <param name="bankAccount">The Bank Account.</param>
        /// <returns>A <see cref="BankAccount"/> object, populated with updated/new values</returns>
        BankAccount Save(BankAccount bankAccount);

        /// <summary>
        /// Deletes an Bank Account
        /// </summary>
        /// <param name="id">The ID of the Bank Account to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);

    }
}