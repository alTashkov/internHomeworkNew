using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphism
{
    public class LocalCourse : Course
    {
        private string lab;

        public string Lab 
        { 
            get
            {
                return lab;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid lab type value!");
                }
                lab = value;
            }
        }

        public LocalCourse(string name) : base(name) 
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public LocalCourse(
            string courseName, 
            string teacherName) : base(courseName, teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        public LocalCourse(
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
            
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
