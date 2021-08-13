using System;

namespace ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Length");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert Width");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert Height");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("=================");
            Box box = new Box(length, width, height);
            box.SurfaceArea();
            box.LateralArea();
            box.Volume();
            Console.WriteLine("=================");
        }
    }
}
