using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _05._Teamwork_Projects
{

    class Team
    {
        public string Founder { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teamsList = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] line = Console.ReadLine().Split('-');
                List<string> membersList = new List<string>();

                string founder = line[0];
                string teamName = line[1];

                Team team = new Team();
                team.Founder = founder;
                team.TeamName = teamName;
                team.Members = membersList;

                if (teamsList.Select(x => x.TeamName).Contains(team.TeamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                else if (teamsList.Select(x => x.Founder).Contains(team.Founder))
                {
                    Console.WriteLine($"{founder} cannot create another team!");
                }

                else
                {
                    teamsList.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {founder}!");
                }
            }

            string teamRegistration = string.Empty;

            while ((teamRegistration = Console.ReadLine()) != "end of assignment")
            {
                string[] command = teamRegistration.Split("->");
                string user = command[0];
                string teamName = command[1];

                if (!teamsList.Select(x => x.TeamName).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                else if (teamsList.Select(x => x.Members).Any(x => x.Contains(user))
                         || teamsList.Select(x => x.Founder).Contains(user))
                {

                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }

                else
                {
                    int teamToJoinIndex = teamsList.FindIndex(x => x.TeamName == teamName);
                    teamsList[teamToJoinIndex].Members.Add(user);
                }
            }

            var teamsToDisband = teamsList.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0);
            var fullTeams = teamsList.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName)
                .Where(x => x.Members.Count > 0);

            foreach (var team in fullTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Founder}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsToDisband)
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }
}


