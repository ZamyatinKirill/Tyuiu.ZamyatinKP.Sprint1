using Tyuiu.ZamyatinKP.Sprint1.Task0.V20.Lib;

namespace Tyuiu.ZamyatinKP.Sprint1.Task0.V20.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.Equal(13, res);
        }
    }
}