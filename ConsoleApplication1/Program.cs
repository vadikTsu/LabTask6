using System;
using ConsoleApplication1.model;
using ConsoleApplication1.service;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("Awesome Team");

            Worker dev1 = new Developer("John");
            Worker dev2 = new Developer("Mary");
            Worker manager1 = new Manager("Peter");

            dev1.FillWorkDay();
            dev2.FillWorkDay();
            manager1.FillWorkDay();

            team.AddWorker(dev1);
            team.AddWorker(dev2);
            team.AddWorker(manager1);

            team.DisplayTeamInfo();
            team.DisplayDetailedTeamInfo();
        }
    }
}

