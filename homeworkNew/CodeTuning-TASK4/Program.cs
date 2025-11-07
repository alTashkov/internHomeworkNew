using System.Diagnostics;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            

            int number = 10;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number--;
            }

            int[] tempArray = new int[array.Length];
            array.CopyTo(tempArray, 0);

            Stopwatch stopwatch = new Stopwatch();
            TimeSpan timeForSorting = new TimeSpan();

            stopwatch.Start();
            QuickSort.Sort(array, 0, array.Length - 1);
            stopwatch.Stop();
            timeForSorting = stopwatch.Elapsed;
            Console.WriteLine("Time for quick sort: " + timeForSorting.ToString());
            stopwatch.Reset();

            Array.Copy(tempArray, array, tempArray.Length);

            stopwatch.Start();
            SelectionSort.Sort(array);
            stopwatch.Stop();
            timeForSorting = stopwatch.Elapsed;
            Console.WriteLine("Time for selection sort: " + timeForSorting.ToString());
            stopwatch.Reset();

            Array.Copy(tempArray, array, tempArray.Length);

            stopwatch.Start();
            InsertionSort.Sort(array);
            stopwatch.Stop();
            timeForSorting = stopwatch.Elapsed;
            Console.WriteLine("Time for insertion sort: " + timeForSorting.ToString());
            stopwatch.Reset();
        }
    }
}
