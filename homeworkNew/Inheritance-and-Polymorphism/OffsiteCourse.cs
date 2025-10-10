using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphism
{
    public class OffsiteCourse : Course
    {
        private string town;

        public string Town 
        { 
            get
            {
                return town;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid town type value!");
                }
                town = value;
            }
        }

        public OffsiteCourse(string name) : base(name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public OffsiteCourse(
            string courseName, 
            string teacherName) : base(courseName, teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        public OffsiteCourse(
            string courseName, 
            string teacherName, 
            IList<string> students) : base(courseName, teacherName, students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
