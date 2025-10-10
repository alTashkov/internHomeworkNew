using System;

namespace Methods
{
    internal class Methods
    {
        static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides must be positive numbers!");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

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
                default: throw new ArgumentException("Invalid number!");
            }
        }

        static int FindMaxNumberInArray(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Array does not exist or is empty!");
            }

            int maxNumber = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }

            return maxNumber;
        }

        static void PrintAsNumber(object objectToPrint, string format)
        {
            if (objectToPrint == null)
            {
                throw new ArgumentNullException("Object does not exist!");
            }

            if (format == "f")
            {
                Console.WriteLine("{0:f2}", objectToPrint);
                return;
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", objectToPrint);
                return;
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", objectToPrint);
                return;
            }

            Console.WriteLine("Invalid number format!");
        }


        static double CalculateDistance(
            double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(
                (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToText(5));

            Console.WriteLine(FindMaxNumberInArray(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
