using System.Diagnostics;

namespace Assertions
{
    class AssertionsHomework
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array does not exist!");
            Debug.Assert(arr.Length > 0, "Array length must be greater than 0!");
            Debug.Assert(arr.Length > 1, "Array contains single element.");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Debug.Assert(minElementIndex >= 0, "Element index is invalid!");

                T oldValueAtIndex = arr[index];
                T oldValueAtMinElementIndex = arr[minElementIndex];
                Swap(ref arr[index], ref arr[minElementIndex]);

                Debug.Assert(arr[minElementIndex].CompareTo(oldValueAtIndex) == 0 &&
                    arr[index].CompareTo(oldValueAtMinElementIndex) == 0, 
                        "Swapping elements unsuccessful, unable to sort!");
            }
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array does not exist!");

            Debug.Assert(startIndex >= 0, "Start index must be a positive number or 0.");
            int minElementIndex = startIndex;

            Debug.Assert(endIndex  >= 0, "End index must be a positive number or 0.");
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x  != null && y != null, "One or both elements don't exist!");
            T oldX = x;
            x = y;
            y = oldX;
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null && value != null, "Array or value does not exist!");
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null && value != null, "Array does not exist or value is invalid!");
            Debug.Assert(startIndex >= 0, "Start index must be greater than 0.");
            Debug.Assert(endIndex >= 0, "End index must be greater than 0.");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }

        static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));

            int[] arrayBeforeSort = arr;
            SelectionSort(arr);
            Debug.Assert(arrayBeforeSort != arr, "Sorting was not performed!");

            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SelectionSort(new int[0]); // Test sorting empty array
            SelectionSort(new int[1]); // Test sorting single element array

            int isCurrentValueFound = BinarySearch(arr, -1000);
            Debug.Assert(isCurrentValueFound > 0, "Value -1000 not found in array!");
            Console.WriteLine(BinarySearch(arr, -1000));

            isCurrentValueFound = BinarySearch(arr, 0);
            Debug.Assert(isCurrentValueFound > 0, "Value 0 not found in array!");
            Console.WriteLine(BinarySearch(arr, 0));

            isCurrentValueFound = BinarySearch(arr, 17);
            Debug.Assert(isCurrentValueFound > 0, "Value 17 not found in array!");
            Console.WriteLine(BinarySearch(arr, 17));

            isCurrentValueFound = BinarySearch(arr, 10);
            Debug.Assert(isCurrentValueFound > 0, "Value 10 not found in array!");
            Console.WriteLine(BinarySearch(arr, 10));

            isCurrentValueFound = BinarySearch(arr, 1000);
            Debug.Assert(isCurrentValueFound > 0, "Value 1000 not found in array!");
            Console.WriteLine(BinarySearch(arr, 1000));
        }
    }
}