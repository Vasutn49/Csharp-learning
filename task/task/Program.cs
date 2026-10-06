//basic syntax
using ConsoleApp1;
using System;
using variable;
class Program
{
    public static void Main()
    {
        //local variable
        //int a = 8;
        //int b = 5;
        //Console.Write(a);
        //Console.WriteLine(b);

        //int a=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(a);

        //object creation
        //college obj = new college();
        //obj.student_id = 44;
        //obj.student_name = "yuva";
        //obj.college_name = "svpp";
        //obj.student_details();
        //Console.WriteLine("------------------------------------------------------------------");
        //college obj1 = new college();
        //obj1.student_id = 45;
        //obj1.student_name = "vani";
        //obj1.college_name = "vvn";
        //obj1.student_details();

        //example 2

        //employee obj1 = new employee();
        //obj1.employee_id = 1;
        //obj1.employee_name = "vimal";
        //obj1.employee_email = "vimal@gmial";
        //obj1.company_name = "zoho";

        //obj1.employee_details();
        //Console.Write("enter your name:");
        //string name=Console.ReadLine();
        //Console.WriteLine(name);

        student obj = new student();
        obj.student_id = 1;
        obj.student_name = "vimal";
        obj.student_email = "vimal@gmail.com";
        obj.student_ph_no = 847983458934;
        obj.student_details();
    }
}