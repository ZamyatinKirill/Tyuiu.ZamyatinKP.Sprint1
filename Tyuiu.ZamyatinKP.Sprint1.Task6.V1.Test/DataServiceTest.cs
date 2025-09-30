using Tyuiu.ZamyatinKP.Sprint1.Task6.V1.Lib;

namespace Tyuiu.ZamyatinKP.Sprint1.Task6.V1.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            string strTest = "1";
            DataService ds = new DataService();
            string res = ds.SymbolCode(strTest);
            string wait = "49";
            Assert.Equal(res, wait);
        }
    }
}