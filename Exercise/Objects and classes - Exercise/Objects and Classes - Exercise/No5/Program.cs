//83/100
using System;
using System.Collections.Generic;
using System.Linq;

namespace No5
{
    class Teams
    {
        public string NameOfTeam { get; set; }
        public string NameOfCreator { get; set; }
        public List<string> Members { get; set; }
        public override string ToString()
        {
            return $"{NameOfTeam}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Teams> listOfTeams = new List<Teams>();
            for(int i = 0; i <= n - 1; i++)
            {
                string[] newTeamData = Console.ReadLine().Split("-").ToArray();
                Teams newTeam = new Teams();
                bool alreadyCreated = false;
                foreach(var item in listOfTeams)
                {
                    if (item.NameOfTeam == newTeamData[1])
                    {
                        alreadyCreated = true;
                        Console.WriteLine($"Team {item.NameOfTeam} was already created!");
                        break;
                    }
                }
                bool sameCreator = false;
                foreach (var item in listOfTeams)
                {
                    if (item.NameOfCreator == newTeamData[0])
                    {
                        sameCreator = true;
                        Console.WriteLine($"{item.NameOfCreator} cannot create another team!");
                        break;
                    }
                }

                if (alreadyCreated == false && sameCreator==false)
                {
                    newTeam.NameOfTeam = newTeamData[1];
                    newTeam.NameOfCreator = newTeamData[0];
                    newTeam.Members = new List<string> {newTeamData[0]};
                    listOfTeams.Add(newTeam);
                    Console.WriteLine($"Team {newTeam.NameOfTeam} has been created by {newTeam.NameOfCreator}!");
                }
                
            }
            string assignment = Console.ReadLine();
            while(assignment!="end of assignment")
            {
                string[] textAsArr = assignment.Split("->").ToArray();
                string nameOfJoiner = textAsArr[0];
                string nameOfWantedTeam = textAsArr[1];
                bool validNameOfTeam = false;
                foreach(var item in listOfTeams)
                {
                    if (nameOfWantedTeam == item.NameOfTeam)
                    {
                        validNameOfTeam = true;
                        break;
                    }
                }
                bool neverBeenInATeam = true;
                foreach(var item in listOfTeams)
                {
                    foreach(var membersInTeam in item.Members)
                    {
                        if (nameOfJoiner == membersInTeam)
                        {
                            neverBeenInATeam = false;

                        }
                    }
                }
                if (validNameOfTeam == false)
                {
                    Console.WriteLine($"Team {nameOfWantedTeam} does not exist!");
                }
                else if (neverBeenInATeam == false)
                {
                    Console.WriteLine($"Member {nameOfJoiner} cannot join team {nameOfWantedTeam}!");
                }
                else if (validNameOfTeam==true && neverBeenInATeam==true)
                {
                    foreach (var item in listOfTeams)
                    {
                        if (nameOfWantedTeam == item.NameOfTeam)
                        {
                            item.Members.Add(nameOfJoiner);
                        }
                    }
                }
                assignment = Console.ReadLine();
            }
            List<Teams> finalTeams = new List<Teams>();
            List<Teams> disbandTeams = new List<Teams>();
            foreach (var item in listOfTeams)
            {
                if (item.Members.Count == 1)
                {
                    disbandTeams.Add(item);
                }
                else
                {
                    finalTeams.Add(item);
                }
            }
            finalTeams = finalTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.NameOfTeam).ToList();
            foreach (var item in finalTeams)
            {
                item.Members.RemoveAt(0);
            }
            foreach (var item in finalTeams)
            {
                item.Members.Sort();
            }
           

            
            foreach (var item in finalTeams)
            {
                Console.WriteLine(item.NameOfTeam);
                Console.WriteLine($"- {item.NameOfCreator}");
                foreach(var members in item.Members)
                {   
                    Console.WriteLine($"-- {members}");
                }
            }
            Console.WriteLine("Teams to disband:");
            disbandTeams=disbandTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.NameOfTeam).ToList();
            foreach (var item in disbandTeams)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
