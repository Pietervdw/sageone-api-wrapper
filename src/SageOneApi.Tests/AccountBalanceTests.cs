using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SageOneApi.Tests
{
	[TestClass]
	public class AccountBalanceTests : TestBase
	{
		[TestMethod]
		public void GetAccountBalances()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var accountBalances = api.AccountBalanceRequest.Get(DateTime.Now.AddMonths(-1), DateTime.Now);
		}

		[TestMethod]
		public void GetAccountBalanceBudgetsById()
		{
			int id = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var budgets = api.AccountBalanceRequest.GetAccountBudgetsById(id);
		}

		[TestMethod]
		public void GetAccountBalanceBudgets()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var budgets = api.AccountBalanceRequest.GetAccountBudgets();
		}
	}
}
