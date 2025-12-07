using Tyuiu.BritovDS.Sprint5.Task7.V4.Lib;

namespace Tyuiu.BritovDS.Sprint5.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Cruise\AppData\Local\Temp\OutPutDataFileTask7V4.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}