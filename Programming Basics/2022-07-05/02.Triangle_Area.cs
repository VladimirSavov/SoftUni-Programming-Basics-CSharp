using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = side * height / 2;
            Console.WriteLine("{0:F2}", area);
        }
    } 
}
