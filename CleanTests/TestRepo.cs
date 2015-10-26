using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanRepo;
using CleanNotes;
using System.Collections.Generic;

namespace CleanTests
{
    [TestClass]
    public class TestRepo
    {
        [TestMethod]
        public void TestInMemoryRepositoryCycle()
        {
            NoteRepo inMemoryNoteRepo = new NoteRepo();
            testSpecificRepo(inMemoryNoteRepo);
        }

        [TestMethod]
        public void TestJsonFileRepositoryCycle()
        {
            JsonFileRepo jsonFileRepo = new JsonFileRepo(TestFileIO.FILE_PATH);
            testSpecificRepo(jsonFileRepo);
        }

        private static void testSpecificRepo(AbstractRepo<Note,int> repo)
        {
            Note note1 = new Note("gunoi", "du gunoiu");
            Note note2 = new Note("vase", "spala vasele");

            repo.Save(note1);
            repo.Save(note2);

            Assert.AreEqual(2, repo.Size());

            Note found = repo.FindByID(1);
            Assert.IsNotNull(found);
            Assert.AreEqual(found.Title, "vase");

            try
            {
                repo.FindByID(4);
                Assert.Fail();
            }
            catch (RepoException) { }

            List<Note> all = repo.GetAll();
            Assert.AreEqual(note1, all[0]);
            
        }

        [TestInitialize]
        public void CleanUp()
        {
            Utils.ClearFile(TestFileIO.FILE_PATH);
        }
    }
}
