namespace Ex6._03
{
    internal class Program
    {
        int i = 0;
        for (i = 0; i< 100;) 
        {
           if (i % 10 == 0)
           {
            Console.WriteLine(array[i]);
            if (array[i] == expectedValue ) 
            {
               i = 666;
            }
            i++;
           }
           else
        {
            Console.WriteLine(array[i]);
            i++;
        }
        }
        // More code here
        if (i == 666)
        {
            Console.WriteLine("Value Found");
        }
    }
}
