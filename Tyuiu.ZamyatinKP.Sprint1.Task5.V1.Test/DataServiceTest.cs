using Tyuiu.ZamyatinKP.Sprint1.Task5.V1.Lib;


namespace Tyuiu.ZamyatinKP.Sprint1.Task5.V1.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            double x1 = 0;
            double y1 = 0;
            double x2 = 3;
            double y2 = 4;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.Equal(5, res);
        }
    }
}