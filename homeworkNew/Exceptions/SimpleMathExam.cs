namespace Exceptions
{
    public class SimpleMathExam : Exam
    {
        public int ProblemsSolved { get; private set; }

        public SimpleMathExam(int problemsSolved)
        {
            if (problemsSolved < 0)
            {
                throw new ArgumentNullException("Amount of solved problems must be positive!");
            }
            else if (problemsSolved > 10)
            {
                throw new ArgumentOutOfRangeException("Amount of solved problems is greater than actual problems amount!");
            }

            this.ProblemsSolved = problemsSolved;
        }

        public override ExamResult Check()
        {
            if (ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: nothing done.");
            }
            else if (ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }

            return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }
    }
}