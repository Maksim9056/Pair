namespace ConsoleApp29
{
    internal class Program
    {


        /// <summary>
        ///  Напишите обобщенный класс Pair<T, U>,
        ///  который хранит пару значений типов T и U.
        ///  Затем напишите ограничение для этого класса,
        ///  чтобы он мог работать только с типами, 
        ///  которые являются ссылочными типами (class). 
        ///  Затем напишите метод void Swap(),
        ///  который меняет местами значения пары
        /// </summary>
        /// <param name="args"></param>
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