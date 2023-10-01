using System;

namespace ConsoleApplication1.model
{
    public class Manager : Worker
    {
        private Random random;

        public Manager(string name) : base(name)
        {
            Position = "Manager";
            random = new Random();
        }

        public override void FillWorkDay()
        {
            int callCount1 = random.Next(1, 11);
            for (int i = 0; i < callCount1; i++)
            { 
                Call();
            }
            
            Relax();
            
            int callCount2 = random.Next(1, 6);
            for (int i = 0; i < callCount2; i++)
            { 
                Call(); 
            }
        }
    }
}