using Tyuiu.ZamyatinKP.Sprint1.Task7.V22.Lib;

namespace Tyuiu.ZamyatinKP.Sprint1.Task7.V22.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.Equal(x, res);
        }
    }
}