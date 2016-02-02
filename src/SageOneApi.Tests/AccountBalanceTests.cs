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
			var accountBalances = Api.AccountBalanceRequest.Get(DateTime.Now.AddMonths(-1), DateTime.Now);
		}

		[TestMethod]
		public void GetAccountBalanceBudgetsById()
		{
			int id = 0;
			var budgets = Api.AccountBalanceRequest.GetAccountBudgetsById(id);
		}

		[TestMethod]
		public void GetAccountBalanceBudgets()
		{
			var budgets = Api.AccountBalanceRequest.GetAccountBudgets();
		}
	}
}
