using Tyuiu.ZheleznyakDN.Sprint1.Task0.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("результат " + ds.Calculate());
    }
}