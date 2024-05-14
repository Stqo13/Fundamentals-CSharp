using System;

namespace zapolesno
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegNum = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string largestModel = string.Empty;
            for (int i = 1; i <= kegNum; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > maxVolume)
                {
                    largestModel = model;
                    maxVolume = volume;
                }
            }
            Console.WriteLine(largestModel);
        }
    }
}
