using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну прямоугольника -> ");
            string x = Console.ReadLine();
            double side1 = Int32.Parse(x);

            Console.Write("Введите ширину прямоугольника -> ");
            string y = Console.ReadLine();
            double side2 = Int32.Parse(y);

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine("Площадь = {0}", rectangle.Area);
            Console.WriteLine("Периметр = {0}", rectangle.Perimeter);
        }
    }
}
