using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Student : IStudent
    {
        public string FullName
        {
            get;
            set;
        }
        public int[] Grades
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        
        public Student():this("Noname","Nofullname")
        {
            Grades = new int[0];
        }
        public Student(string name,string fullName)
        {
            Name = name;
            FullName = fullName;
        }

        public double GetAverageGrade()
        {
            double average = 0.0;
            for (int i = 0; i < Grades.Length; i++)
            {
                average += Grades[i];
            }
            average = average / (double)Grades.Length;
            return average;            
        }
        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
