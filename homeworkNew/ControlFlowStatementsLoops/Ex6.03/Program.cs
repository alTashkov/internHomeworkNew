namespace Ex6._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valueHasBeenFound = false;
            for (int i = 0; i < 100; i++)
            {
                int currentValue = array[i];
                Console.WriteLine(currentValue);

                if (i % 10 == 0)
                {
                    if (currentValue == expectedValue)
                    {
                        valueHasBeenFound = true;
                        break;
                    }
                }
            }
            // More code here
            if (valueHasBeenFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
