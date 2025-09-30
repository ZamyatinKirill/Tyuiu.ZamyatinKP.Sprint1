using Tyuiu.ZamyatinKP.Sprint1.Task2.V29.Lib;

namespace Tyuiu.ZamyatinKP.Sprint1.Task2.V29.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 60;
            var res = ds.ConvertSecondsToHours(x);
            Assert.Equal(1, res);
        }
    }
}