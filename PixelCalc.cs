using System;

namespace Pixelcalc
{
    public static class PixelCalc
    {
        public static double CalculatePPI(int width, int height, int diagonal)
        {
            double diagonalResolution = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            return diagonalResolution / diagonal;
        }

        public static double CalculateDiagonalInPixels(int width, int height)
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        }

        public static double CalculateDotPitch(int width, int height, int diagonal)
        {
            return 25.4 / CalculatePPI(width, height, diagonal);
        }
    }
}