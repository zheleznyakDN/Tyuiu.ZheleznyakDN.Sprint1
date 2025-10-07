using Tyuiu.ZheleznyakDN.Sprint1.Task1.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Введите a");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите x");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("результат " + ds.Calculate(a, x, y));
    }
}