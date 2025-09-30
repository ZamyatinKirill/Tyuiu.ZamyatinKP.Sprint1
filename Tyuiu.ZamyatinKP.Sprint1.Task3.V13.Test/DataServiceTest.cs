using Tyuiu.ZamyatinKP.Sprint1.Task3.V13.Lib;

namespace Tyuiu.ZamyatinKP.Sprint1.Task3.V13.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 123;
            var res = ds.MultiplyOfDigits(x);
            Assert.Equal(6, res);
        }
    }
}