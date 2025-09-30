using Tyuiu.ZamyatinKP.Sprint1.Task1.V5.Lib;

namespace Tyuiu.ZamyatinKP.Sprint1.Task1.V5.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.Equal(6, res);
        }
    }
}