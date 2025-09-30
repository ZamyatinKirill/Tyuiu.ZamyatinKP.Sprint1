using Tyuiu.ZamyatinKP.Sprint1.Task4.V16.Lib;

namespace Tyuiu.ZamyatinKP.Sprint1.Task4.V16.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            Assert.Equal(0.2, res);
        }
    }
}