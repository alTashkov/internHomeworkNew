using System.Text;

namespace Exceptions
{
    class ExceptionsHomework
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new NullReferenceException("Array does not exist!");
            }

            if (startIndex < 0)
            {
                throw new ArgumentException("Start index must be a positive number or 0!");
            }

            if (count > arr.Length)
            {
                throw new ArgumentException("Count is larger than array length!");
            }

            if (count < 1)
            {
                throw new ArgumentException("Subsequence must be atleast 1 character long!");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new NullReferenceException("String does not exist!");
            }

            if (count > str.Length)
            {
                throw new ArgumentException("Invalid ending size!");
            }

            if (count < 1)
            {
                throw new ArgumentException("Ending must be alteast 1 character long!");
            }

            if (count == str.Length)
            {
                throw new InvalidOperationException("Ending is same size as string length!");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }
            return result.ToString();
        }

        public static void CheckPrime(int number)
        {
            if (number < 1)
            {
                throw new ArgumentException("Number must be natural!");
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    throw new ArgumentException("The number is not prime!");
                }
            }
        }

        static void Main()
        {
            try
            {
                var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
                Console.WriteLine(substr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
                Console.WriteLine(String.Join(" ", subarr));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
                Console.WriteLine(String.Join(" ", allarr));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
                Console.WriteLine(String.Join(" ", emptyarr));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(ExtractEnding("I love C#", 2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(ExtractEnding("Nakov", 4));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(ExtractEnding("beer", 4));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(ExtractEnding("Hi", 100));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                CheckPrime(23);
                Console.WriteLine("23 is prime.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                CheckPrime(33);
                Console.WriteLine("33 is prime.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            try
            {
                double peterAverageResult = peter.CalcAverageExamResultInPercents();
                Console.WriteLine("Average results = {0:p0}", peterAverageResult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

