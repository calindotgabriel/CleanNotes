using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanNotes;

namespace CleanTests
{
    [TestClass]
    public class NoteTest
    {
        string TITLE = "Clean house";
        string CONTENT = "also call Judy";

        [TestMethod]
        public void TestNote()
        {
            Note note = new Note(TITLE, "");
            Assert.AreEqual(note.Title, TITLE);
            note.Content = CONTENT;
            Assert.AreEqual(note.Content, CONTENT);
        }
    }
}
