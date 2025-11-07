namespace Exceptions
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<Exam> Exams { get; set; }

        public Student(string firstName, string lastName, IList<Exam> exams)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("First name is null or empty!");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("Last name is null or empty!");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new NullReferenceException("Exams list not initialized!");
            }

            if (this.Exams.Count == 0)
            {
                Console.WriteLine("The student has no exams!");
                throw new ArgumentException("No exams assigned to student!");
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                // Cannot calculate average on missing exams
                throw new InvalidOperationException("Cannot calculate average - exams list does not exist!");
            }

            if (this.Exams.Count == 0)
            {
                // No exams --> return -1;
                return -1;
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] = ((double)examResults[i].Grade - examResults[i].MinGrade) / (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
