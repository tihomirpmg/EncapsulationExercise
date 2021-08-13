using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public void SurfaceArea()
        {
            double surfArea = 2 * length * width + 2 * length * height + 2 * width * height;
            Console.WriteLine($"Surface Area = {surfArea:F2}");
        }

        public void LateralArea()
        {
            double latArea = 2 * length * height + 2 * width * height;
            Console.WriteLine($"Lateral Surface Area = {latArea:F2}");
        }

        public void Volume()
        {
            double volume = length * width * height;
            Console.WriteLine($"Volume = {volume:F2}");
        }
    }
}
