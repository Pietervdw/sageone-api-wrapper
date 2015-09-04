using System.Collections.Generic;
using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
    public interface IAccountRequest
    {
        /// <summary>
        /// Gets a single account by ID.
        /// </summary>
        /// <param name="id">The ID of the account.</param>
        /// <returns>A <see cref="Account"/> object</returns>
        /// 
        Account Get(int id);

        /// <summary>
        /// Gets a collection of accounts.
        /// </summary>
        /// <param name="includeSystemAccounts">If set to true will include system accounts</param>
        /// <returns>An List collection of <see cref="Account"/> objects</returns>
        PagingResponse<List<Account>> Get(bool includeSystemAccounts=false);

        /// <summary>
        /// Gets a collection of accounts by category
        /// </summary>
        /// <param name="categoryId">Id of the category</param>
        /// <returns>An List collection of <see cref="Account"/> objects</returns>
        PagingResponse<List<Account>> GetByCategory(int categoryId);

        /// <summary>
        /// Saves the specified account.
        /// </summary>
        /// <param name="account">The account.</param>
        /// <returns>A <see cref="Account"/> object, populated with updated/new values</returns>
        Account Save(Account account);


        /// <summary>
        /// Deletes an account
        /// </summary>
        /// <param name="id">The ID of the account to delete</param>
        /// <returns>True if successfully deleted, otherwise false</returns>
        bool Delete(int id);
    }
}