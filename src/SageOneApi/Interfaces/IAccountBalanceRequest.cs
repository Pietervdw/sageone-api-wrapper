using System;
using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
	public interface IAccountBalanceRequest
	{

		/// <summary>
		/// Gets a single Account Note between two dates
		/// </summary>
		/// <param name="fromDate">From date.</param>
		/// <param name="toDate">To date.</param>
		/// <returns></returns>
		AccountBalance Get(DateTime fromDate, DateTime toDate);

		/// <summary>
		/// Gets the account budgets by id.
		/// </summary>
		/// <param name="budgetId">The budget identifier.</param>
		/// <param name="filter">OData filter.</param>
		/// <param name="skip">OData skip parameter.</param>
		/// <returns></returns>
		PagingResponse<AccountBalance> GetAccountBudgetsById(int budgetId,string filter = "", int skip = 0);

		/// <summary>
		/// Gets the account budgets.
		/// </summary>
		/// <param name="filter">OData filter.</param>
		/// <param name="skip">OData skip parameter.</param>
		/// <returns></returns>
		PagingResponse<AccountBalance> GetAccountBudgets(string filter = "", int skip = 0);
	}
}