﻿namespace Methods
{
    using System;

    public class Methods
    {
        /// <summary>
        /// Calculate triangle area
        /// </summary>
        /// <param Side a="a"></param>
        /// <param Side b="b"></param>
        /// <param Side c="c"></param>
        /// <returns></returns>
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double surface = (a + b + c) / 2;
            double area = Math.Sqrt(surface * (surface - a) * (surface - b) * (surface - c));
            return area;
        }

        /// <summary>
        /// Convert number (from 0 to 9) to text
        /// </summary>
        /// <returns>Number as text</returns>
        static string NumberToText(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentOutOfRangeException("Invalid number!");
        }

        /// <summary>
        /// Find maximal element from given collection
        /// </summary>
        /// <param collection of numbers="elements"></param>
        /// <returns>Maximal element</returns>
        static int FindMax(params int[] elements)
        {
            if (elements != null && elements.Length != 0)
            {
                for (int i = 1; i < elements.Length; i++)
                {
                    if (elements[i] > elements[0])
                    {
                        elements[0] = elements[i];
                    }
                }

                return elements[0];
            }
            else
            {
                throw new Exception("Invalid elements collection !");
            }
        }

        /// <summary>
        /// Write number at console in given format 
        /// </summary>
        static void PrintNumberInFormat(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Invalid format !");
            }
        }

        /// <summary>
        /// Calculate distance between two dots
        /// </summary>
        /// <returns>
        /// Distance between dots
        /// </returns>
        /// <returns>
        /// Is line between them horizontal
        /// </returns>
        /// <returns>
        /// Is line between them vertical
        /// </returns>
        static double CalcDistance(double x1, double y1, double x2, double y2,
                                    out bool isHorizontal, out bool isVertical)
        {
            try
            {
                isHorizontal = (y1 == y2);
                isVertical = (x1 == x2);

                double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                return distance;
            }

            catch (Exception)
            {

                throw new Exception("Can not calculate distance");
            }

        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToText(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintNumberInFormat(1.3, "f");
            PrintNumberInFormat(0.75, "%");
            PrintNumberInFormat(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
