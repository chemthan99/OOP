using System;

namespace LAB04{
    class Programmer : Staff{
        private int bugsPerMonth;

        public Programmer(int bugsPerMonth,string id,string name,double salary)
            :base(id,name,salary)
        {
            this.staffId=id;
            this.staffName=name;
            this.staffSalary=salary;
            this.bugsPerMonth = bugsPerMonth;
           
        }

        public Programmer(){}

        public override void Input()
        {
            base.Input();
            Console.Write("Bugs Per Month : ");
            this.bugsPerMonth = int.Parse(Console.ReadLine());

        }

        public override void Output()
        {
            base.Output();
            Console.Write("Bugs Per Month of Programmer => " + bugsPerMonth );
        }

        public override double GetSalary()
        {
            return bugsPerMonth  < 20 ? base.GetSalary() * 1.1 :  base.GetSalary();
        }

        public int BugsPerMonth { get => bugsPerMonth; set => bugsPerMonth = value; }
    }
}