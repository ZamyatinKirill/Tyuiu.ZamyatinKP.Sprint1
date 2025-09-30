using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZamyatinKP.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            return Math.Round((number % 10) * Math.Round((number / 10 % 10)) * Math.Round((number / 100 % 10)), 3);
        }
    }
}
