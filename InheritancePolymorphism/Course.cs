using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphism
{
    public abstract class Course
    {
        private string name;

        private string teacherName;

        private IList<string> students;

        public string Name 
        { 
            get
            {
                return name;
            } 
            set
            {
                if (value == null)
                {
                    throw new 
                        ArgumentException("Invalid course name value!");
                }
                name = value;
            } 
        }

        public string TeacherName 
        { 
            get
            {
                return teacherName;
            } 
            set
            {
                if (value == null)
                {
                    throw new 
                        ArgumentException("Invalid teacher name!");
                }
                teacherName = value;
            }
        }

        public IList<string> Students 
        { 
            get
            {
                return students;
            }
            set
            {
                if (value == null)
                {
                    throw new 
                        ArgumentException("Students collection doesn't exist!");
                }
                students = value;
            }
        }

        public Course(string name)
        {
            this.Name = name;
        }

        public Course(string name, string teacherName)
        {
            this.Name = name;
            this.teacherName = teacherName;
        }

        public Course(
            string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + 
                    string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{this.GetType().Name} {"{"} Name = ");
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }
    }
}
