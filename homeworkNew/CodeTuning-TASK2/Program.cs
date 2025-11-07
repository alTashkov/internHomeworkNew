namespace CodeTuning.TASK2
{
    public class PerformanceComparison
    {
        public static T Add<T>(T number1, T number2)
        {
            if (number1 == null)
            {
                throw new ArgumentNullException("First number does not exist!");
            }

            if (number2 == null)
            {
                throw new ArgumentNullException("Second number does not exist!");
            }

            dynamic a = number1;
            dynamic b = number2;
            return a + b;
        }

        public static T Subtract<T>(T number1, T number2)
        {
            if (number1 == null)
            {
                throw new ArgumentNullException("First number does not exist!");
            }

            if (number2 == null)
            {
                throw new ArgumentNullException("Second number does not exist!");
            }

            dynamic a = number1;
            dynamic b = number2;

            return a - b;
        }

        public static T Multiply<T>(T number1, T number2)
        {
            if (number1 == null)
            {
                throw new ArgumentNullException("First number does not exist!");
            }

            if (number2 == null)
            {
                throw new ArgumentNullException("Second number does not exist!");
            }

            dynamic a = number1;
            dynamic b = number2;

            return a * b;
        }

        public static T Divide<T>(T number1, T number2)
        {
            if (number1 == null)
            {
                throw new ArgumentNullException("First number does not exist!");
            }

            if (number2 == null)
            {
                throw new ArgumentNullException("Second number does not exist!");
            }

            dynamic a = number1;
            dynamic b = number2;

            return a / b;
        }

        public static T Increment<T>(T number, T incrementor)
        {
            if (number == null)
            {
                throw new ArgumentNullException("First number does not exist!");
            }

            if (incrementor == null)
            {
                throw new ArgumentNullException("Second number does not exist!");
            }

            dynamic a = number;
            dynamic b = incrementor;

            return a + Math.Abs(b);
        }

        public static double SquareRoot<T>(T number)
        {
            double numberInDoubleFormat = Convert.ToDouble(number);
            return Math.Pow(numberInDoubleFormat, 0.5);
        }

        public static double NaturalLog<T>(T number)
        {
            double numberInDoubleFormat = Convert.ToDouble(number);
            return Math.Log(numberInDoubleFormat, Math.E);
        }

        public static double Sine<T>(T number)
        {
            double numberInDoubleFormat = Convert.ToDouble(number);
            return Math.Sin(numberInDoubleFormat);
        }
    }
}
