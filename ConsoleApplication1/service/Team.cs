using System;
using System.Collections.Generic;
using ConsoleApplication1.model;

namespace ConsoleApplication1.service
{
    public class Team
    {
        private readonly string teamName;
        private List<Worker> workers;

        public Team(string name)
        {
            teamName = name;
            workers = new List<Worker>();
        }

        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }

        public void DisplayTeamInfo()
        {
            Console.WriteLine($"Team: {teamName}");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.GetName());
            }
        }

        public void DisplayDetailedTeamInfo()
        {
            Console.WriteLine($"Team: {teamName}");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }
        }
    }
}