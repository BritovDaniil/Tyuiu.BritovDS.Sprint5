using Tyuiu.BritovDS.Sprint5.Task1.V30.Lib;
namespace Tyuiu.BritovDS.Sprint5.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Ïîëüçîâàòåëü\source\repos\Tyuiu.BabaiKV.Sprint5\Tyuiu.BabaiKV.Sprint5.Task1.V30\bin\Debug\net8.0\outPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}