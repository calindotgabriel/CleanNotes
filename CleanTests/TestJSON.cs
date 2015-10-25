using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanNotes;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace CleanTests
{
    [TestClass]
    public class TestJSON
    {
        string RESULT 
            = "{\"content\":\"be more productive\",\"id\":0,\"title\":\"asap\"}";


        [TestMethod]
        public void TestJSONify()
        {
            Note note = new Note("asap", "be more productive");

            string s = Serializer.Serialize(note);

            Assert.AreEqual(s, RESULT);
        }

        [TestMethod]
        public void TestDeJSONify()
        {
            Note note = Serializer.Deserialize(RESULT);
            Assert.AreEqual(note.Title, "asap");
        }
    }
}
