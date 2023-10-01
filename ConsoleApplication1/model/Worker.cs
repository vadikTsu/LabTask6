using System;

namespace ConsoleApplication1.model
{
    public abstract class Worker
    {
        protected string Name;
        protected string Position;
        protected int WorkDay;

        public Worker(string name)
        {
            Name = name;
        }

        public abstract void FillWorkDay();

        public void Call()
        {
            Console.WriteLine($"{Name} is making a call.");
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} is writing code.");
        }

        public void Relax()
        {
            Console.WriteLine($"{Name} is relaxing.");
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return $"{Name} - {Position} - {WorkDay} workdays";        
        }
    }
}