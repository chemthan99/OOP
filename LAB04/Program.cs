using System;

namespace LAB04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Staff [] staffs = new Staff[n];
            for(int i = 0; i< n ;i++){
                if (i %  2 == 0)
                   staffs[i] = new Tester();                                 
                else
                    staffs[i] = new Programmer();
                staffs[i].Input();
                   
                                 
            }
            double sum = 0;

            foreach(Staff staff in staffs){
                //staff.Output();
                //Console.WriteLine();
                sum+=staff.GetSalary();
            }
            Console.WriteLine(sum);
        }
    }
}
