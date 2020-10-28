using System;

namespace LAB04{
    abstract class Staff{
        protected string staffId;
        protected string staffName;
        protected double staffSalary;

         public Staff(string staffId, string staffName, double staffSalary)
        {
            this.staffId= staffId;
            this.staffName = staffName;
            this.staffSalary = staffSalary;
        }

        public string StaffId { get => staffId; set => staffId = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public double StaffSalary { get => staffSalary; set => staffSalary = value; }
   
        public Staff(){}

        public virtual void Input(){
            Console.Write("Staff ID : ");
            this.staffId = Console.ReadLine();
            Console.Write("Staff Name : ");
            this.staffName = Console.ReadLine();
            Console.Write("Staff Salary : ");
            this.staffSalary = int.Parse(Console.ReadLine());
        }

        public virtual void Output(){
            Console.Write($"Staff ID : {this.staffId}\n" ); 
            Console.Write($"Staff Name : {this.staffName}\n" );                 
            Console.Write($"Staff Salary : {this.staffSalary}\n" );                          
        }

        public virtual double GetSalary(){
            return StaffSalary;
        }

   
   
    }
}