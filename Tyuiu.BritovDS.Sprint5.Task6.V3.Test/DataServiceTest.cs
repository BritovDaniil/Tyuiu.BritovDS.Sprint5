using Tyuiu.BritovDS.Sprint5.Task7.V2.Lib;

namespace Tyuiu.BritovDS.Sprint5.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\Users\kosya\AppData\Local\Temp\OutPutFileTask7V2.txt";

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}