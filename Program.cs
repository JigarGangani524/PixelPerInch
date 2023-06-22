using Pixelcalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Enter Screen dimensions");
            Console.WriteLine("2. Exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Enter screen width: ");
                int width = int.Parse(Console.ReadLine());

                Console.Write("Enter screen height: ");
                int height = int.Parse(Console.ReadLine());

                Console.Write("Enter diagonal size: ");
                int diagonal = int.Parse(Console.ReadLine());

                double ppi = PixelCalc.CalculatePPI(width, height, diagonal);
                double diagonalPixels = PixelCalc.CalculateDiagonalInPixels(width, height);
                double dotPitch = PixelCalc.CalculateDotPitch(width, height, diagonal);

                Console.WriteLine($"PPI: {ppi}");
                Console.WriteLine($"Diagonal in pixels: {diagonalPixels}");
                Console.WriteLine($"Dot Pitch: {dotPitch}");
            }
            else if (input == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
