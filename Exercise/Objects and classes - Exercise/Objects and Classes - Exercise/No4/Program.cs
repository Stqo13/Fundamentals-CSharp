using System;
using System.Collections.Generic;
using System.Linq;
namespace No4
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> listOfStudents = new List<Student>();

            for (int i = 0; i <= n - 1; i++)
            {
                Student currentStudent = new Student();
                string[] text = Console.ReadLine().Split().ToArray();
                currentStudent.FirstName = text[0];
                currentStudent.LastName = text[1];
                currentStudent.Grade = double.Parse(text[2]);
                listOfStudents.Add(currentStudent);

            }

            listOfStudents = listOfStudents.OrderByDescending(x => x.Grade).ToList();
            
            foreach (var item in listOfStudents)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}