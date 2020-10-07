﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* BÀI 1*/
            /*
            Account account = new Account("X001",3000);
            Console.WriteLine("Thông tin tài khoản hiện tại : ");
            Console.Write(account.ToString());
            account.AccountId="Z001";
            account.Money=9999;
            Console.WriteLine("Thông tin tài khoản sau thay đổi : ");
            Console.Write(account.ToString());
            */

            /*BÀI 2*/
            // Book book = new Book("B001","Book #1",3000,0);
            // Console.WriteLine("Thông tin quyển sách hiện tại : ");
            // Console.WriteLine(book.ToString());
            // Console.WriteLine("Giá bán của sách : {0}",book.MoneyOfBook());
            // Console.WriteLine();
            // Console.WriteLine("Thông tin quyển sách sau cập nhật : ");
            // book.BookSale=1000;
            // Console.WriteLine(book.ToString());
            // Console.Write("Giá bán của sách : {0}",book.MoneyOfBook());

            /*BÀI 3*/
            // Student student = new Student("ST001","Cavarly",2000,"123 Tôn Đản");
            // Console.WriteLine("Thông tin sinh viên: ");
            // Console.WriteLine(student.ToString());
            // Console.WriteLine("Tuổi của sinh viên: " + student.StudentAge());


            /*BÀI 4*/
            // Circle circle = new Circle();
            // Console.WriteLine(circle.ToString());
            // Console.WriteLine("Nhập hình tròn : ");
            // Console.Write("Nhập bán kính R : ");
            // circle.Input();
            // Console.WriteLine();
            // Console.WriteLine(circle.ToString());
            // Console.WriteLine("Diện tích hình tròn " + circle.CalculateArea());
            // Console.WriteLine("Chu vi hình tròn " + circle.CalculatePerimeter());

            /*BÀI 5*/
            Console.Write("Nhập số lượng hình tròn : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            List<Circle> listCircle = new List<Circle>(n);
            for (int i = 0; i < n; i++)
            {
                Circle circle = new Circle();
                Console.Write("Nhập bán kính R : ");
                circle.Input();
                listCircle.Add(circle);       
            }
            Circle maxCircle = MaxCircle(listCircle);
            Console.WriteLine("Max Circle: " + maxCircle.ToString());
            foreach (Circle x in listCircle)
                x.Output();
            listCircle.Select(p => p).OrderBy(p => p.CalculateArea());
            
            foreach (Circle x in listCircle)
                x.Output();
        }

        public static Circle MaxCircle(List<Circle> listCircle)
        {
            Circle maxCircle = listCircle[0];
            foreach (Circle x in listCircle)
            {
                if (x.CalculateArea() > maxCircle.CalculateArea())
                {
                    maxCircle = x;
                }
            }
            return maxCircle;
        }
    }
}