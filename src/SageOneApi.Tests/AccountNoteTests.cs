using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class AccountNoteTests : TestBase
    {
        [TestMethod]
        public void GetAllAccountNotes()
        {
            var accountNotes = Api.AccountNoteRequest.Get();
        }

        [TestMethod]
        public void GetAccountNote()
        {
            int accountNoteId = 0;
            var accountNote = Api.AccountNoteRequest.Get(accountNoteId);
        }

        [TestMethod]
        public void SaveAccountNote()
        {
            var accountNote = new AccountNote
            {
                AccountId = 0,
                ActionDate = DateTime.Now.ToShortDateString(),
                EntryDate = DateTime.Now.ToShortDateString(),
                Status = true,
                Subject = "A new note about this account",
                Note = "A Note Here."
            };
            var newAccountNote = Api.AccountNoteRequest.Save(accountNote);
        }

        [TestMethod]
        public void DeleteAccountNote()
        {
            int accountNoteId = 0;
            var result = Api.AccountNoteRequest.Delete(accountNoteId);
        }
    }
}
