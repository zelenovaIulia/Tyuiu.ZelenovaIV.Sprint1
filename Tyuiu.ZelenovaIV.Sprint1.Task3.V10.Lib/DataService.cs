using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZelenovaIV.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            int rub = (int)number;
            int kopeek = (int)Math.Round((number - rub) * 100);
            string sum = $"{rub}.{(int)Math.Round((number - rub) * 10)}";

            return $"{sum} руб. - это {rub} руб. {kopeek} коп.";
        }
    }
}
