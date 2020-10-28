using System;

namespace LAB04{
    class Tester : Staff{
        private int overtime;

        public Tester(int overtime,string id,string name,double salary)
            :base(id,name,salary)
        {
            this.staffId=id;
            this.staffName=name;
            this.staffSalary=salary;
            this.overtime = overtime;
           
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Overtime : ");
            this.overtime = int.Parse(Console.ReadLine());

        }
        
        public Tester(){}

        public override void Output()
        {
            base.Output();
            Console.Write("Overtime => " + overtime );
        }

        const int OT_VALUE = 200000;

        public override double GetSalary()
        {
            return 
            base.GetSalary() + overtime*OT_VALUE;
        }

    }
}