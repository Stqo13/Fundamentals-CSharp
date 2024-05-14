using System;
using System.Collections.Generic;
using System.Linq;
namespace No7
{
    class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> allPeople = new List<Person>();
            while (input != "End")
            {
                string[] arrAsInput = input.Split().ToArray();
                bool firstSeenOfId = true;
                foreach(var item in allPeople)
                {
                    if(item.ID== int.Parse(arrAsInput[1]))
                    {
                        firstSeenOfId = false;
                        item.Name = arrAsInput[0];
                        item.Age = int.Parse(arrAsInput[2]);
                    }
                }
                if (firstSeenOfId)
                {
                    Person currentPerson = new Person();
                    currentPerson.Name = arrAsInput[0];
                    currentPerson.ID = int.Parse(arrAsInput[1]);
                    currentPerson.Age = int.Parse(arrAsInput[2]);
                    allPeople.Add(currentPerson);
                }
                input = Console.ReadLine();
            }
            allPeople=allPeople.OrderBy(x => x.Age).ToList();
            foreach(var item in allPeople)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
