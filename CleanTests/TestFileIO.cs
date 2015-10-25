using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanTests
{
    [TestClass]
    public class TestFileIO
    {
        public static string FOLDER_PATH = @"C:\Users\calindotgabriel\Documents\Visual Studio 2013\Projects\CleanNotes";
        public static string FILE_NAME = "TestFile.txt";
        public static string FILE_PATH = System.IO.Path.Combine(FOLDER_PATH, FILE_NAME);

        [TestMethod]
        public void TestWrite()
        {
            /*
            System.IO.File.WriteAllText(PATH, "swag123");
            string text = System.IO.File.ReadAllText(PATH);
            Console.Write(text);
            */
        }
    }
}
