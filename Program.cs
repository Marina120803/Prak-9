using System;

namespace aip;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите цену товара: ");
        int x = int.Parse(Console.ReadLine());
        int i = 10;

        do
        {
            Console.WriteLine("{0} штук товара стоят {1} руб", i, i * x);
            i += 10;
        }
        while (i <= 200);
        Console.ReadKey();
    }
}