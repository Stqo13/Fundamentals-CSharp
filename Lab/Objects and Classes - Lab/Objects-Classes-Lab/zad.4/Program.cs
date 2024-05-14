using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            bool flag = false;
            while (true)
            {
                string[] studentInfo = Console.ReadLine().Split();
                for (int i = 0; i < studentInfo.Length; i++)
                {
                    if (studentInfo[i]=="end")
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    break;
                }
                string firstName = studentInfo[0];
                string secondName = studentInfo[1];
                string age = studentInfo[2];
                string town = studentInfo[3];
                Student student = new Student(firstName, secondName, age, town);
                students.Add(student);
            }
            string city = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];
                if (city==currentStudent.Town)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.SecondName} is {currentStudent.Age} years old.");
                }
            }
        }
        public class Student
        {
            public Student(string firstName, string secondName, string age, string town)
            {
                FirstName = firstName;
                SecondName = secondName;
                Age = age;
                Town = town;
            }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string Age { get; set; }
            public string Town { get; set; }
        }
    }
}
