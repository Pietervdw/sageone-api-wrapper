using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
    [TestClass]
    public class ItemNoteTests : TestBase
    {
        [TestMethod]
        public void GetAllItemNotes()
        {
            var itemNotes = Api.ItemNoteRequest.Get();
        }

        [TestMethod]
        public void GetItemNote()
        {
            int itemNoteId = 0;
            var itemNote = Api.ItemNoteRequest.Get(itemNoteId);
        }

        [TestMethod]
        public void SaveItemNote()
        {
            var itemNote = new ItemNote
            {
                ItemId = 0,
                Status = true,
                ActionDate = DateTime.Now,
                EntryDate = DateTime.Now,
                HasAttachments = false,
                Subject = "A note about this item",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at scelerisque tortor."
            };

            var newItemNote = Api.ItemNoteRequest.Save(itemNote);
        }

        [TestMethod]
        public void DeleteItemNote()
        {
            int itemNoteId = 0;
            var result = Api.ItemNoteRequest.Delete(itemNoteId);
        }
    }
}
