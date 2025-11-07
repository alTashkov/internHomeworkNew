namespace Exceptions
{
    public class ExamResult
    {
        public int Grade { get; private set; }
        public int MinGrade { get; private set; }
        public int MaxGrade { get; private set; }

        public string Comments { get; private set; }

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0)
            {
                throw new ArgumentException("Grade can't be negative!");
            }

            if (minGrade < 0)
            {
                throw new ArgumentException("Minimum grade can't be negative!");
            }

            if (maxGrade <= minGrade)
            {
                throw new ArgumentException("Minimum grade can't be greater than maximum grade!");
            }

            if (comments == null || comments == "")
            {
                throw new ArgumentException("Comments don't exist or are empty!");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }
    }
}
