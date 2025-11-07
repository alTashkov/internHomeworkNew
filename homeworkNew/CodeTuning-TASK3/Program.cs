using CodeTuning.TASK2;
using System.Diagnostics;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            //Square root
            //Double
            double numDouble = 12.3d;
            stopwatch.Start();
            PerformanceComparison.SquareRoot(numDouble);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed double square root: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();

            //Decimal
            decimal numDecimal = 12.3m;
            stopwatch.Start();
            PerformanceComparison.SquareRoot(numDecimal);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed decimal square root: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();

            //Float
            float numFloat = 12.3f;
            stopwatch.Start();
            PerformanceComparison.SquareRoot(numFloat);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed float square root: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();

            //Natural log
            //Double
            stopwatch.Start();
            PerformanceComparison.NaturalLog(numDouble);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed double natural log: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();

            //Decimal
            stopwatch.Start();
            PerformanceComparison.NaturalLog(numDecimal);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed decimal natural log: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();

            //Float
            stopwatch.Start();
            PerformanceComparison.NaturalLog(numFloat);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed float natural log: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();

            //Sinus
            //Double
            stopwatch.Start();
            PerformanceComparison.Sine(numDouble);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed double sine: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();

            //Decimal
            stopwatch.Start();
            PerformanceComparison.Sine(numDecimal);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed decimal sine: {0}", stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine();

            //Float
            stopwatch.Start();
            PerformanceComparison.Sine(numFloat);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed float sine: {0}", stopwatch.Elapsed);
            stopwatch.Reset();
        }
    }
}
