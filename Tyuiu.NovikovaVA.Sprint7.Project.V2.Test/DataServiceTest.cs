namespace Tyuiu.NovikovaVA.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromFileData()
        {
            
                string path = @"C:\Users\User\source\repos\Tyuiu.NovikovaVA.Sprint7\Tyuiu.NovikovaVA.Sprint7.Project.V2\База данных.csv";
                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            
        }
    }
}