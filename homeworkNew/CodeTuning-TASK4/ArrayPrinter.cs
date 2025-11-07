namespace Task4
{
    public static class ArrayPrinter
    {
        public static void PrintArray(int[] arr)
        {
            foreach (int val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}
