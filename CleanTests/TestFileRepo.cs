using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanRepo;
using CleanNotes;

namespace CleanTests
{
    [TestClass]
    public class TestFileRepo
    {
        string PATH = System.IO.Path.Combine(TestFileIO.FOLDER_PATH, "JsonRepo.txt");

        [TestMethod]
        public void TestJSONFileRepoQuerying()
        {
            JsonFileRepo repo = new JsonFileRepo(PATH);
            Note note = new Note("1", "234");
            repo.Save(note);

            
            Assert.AreEqual(note.Title, repo.GetAll()[0].Title);
        }

        [TestMethod]
        public void TestCorrectJsonRepoIndex()
        {
            
            JsonFileRepo repo = new JsonFileRepo(PATH);
            
            Note note = new Note("bataie", "1234");
            repo.Save(note);

            Assert.AreEqual(1, repo.Size());
        }

        // must be public else it doesn't get executed
        [TestInitialize]
        public void CleanUpFile()
        {
            Utils.ClearFile(PATH);
        }


    }
}
