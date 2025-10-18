using Tyuiu.ZelenovaIV.Sprint1.Task3.V10.Lib;
    internal class Program
{
    private static void Main(string[] args)
    {
        DataService dataService = new DataService();
        var x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(dataService.NumberToMoney(x));

    }
}