namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int, int> pair = new Pair<int, int>(1, 2);

            Console.WriteLine($"Параметры : {pair.Value}    {pair.Value2}"  );
            pair.Swap();
            Console.WriteLine($"Параметры : {pair.Value}    {pair.Value2}");

            Console.ReadLine();
        }
    }
}