namespace Methods
{
    internal class Student
    {
        private string? firstName;

        private string? lastName;

        private string? otherInfo;

        public string? FirstName 
        { 
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string? LastName 
        { 
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string? OtherInfo 
        { 
            get
            {
                return otherInfo;
            }
            set
            {
                otherInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            if (this.OtherInfo != null && other.OtherInfo != null)
            {
                DateTime firstDate =
                    DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));

                DateTime secondDate =
                    DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));

                return firstDate > secondDate;
            }
            else
            {
                throw new ArgumentException(
                    "Not enough information about the students!\nFill in other info!");
            }
            
        }
    }
}
