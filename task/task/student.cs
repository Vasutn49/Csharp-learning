using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using variable;

namespace ConsoleApp1
{
    internal class student
    {
        public int student_id;

        public string student_name;

        public long student_ph_no;

        public string student_email;

        public static string college;




        public const string company = "zoho";

        public void student_details()
        {
            college = "einstein collage";
            Console.WriteLine(student_id);
            Console.WriteLine(student_name);
            Console.WriteLine(student_ph_no);
            Console.WriteLine(student_email);
            Console.WriteLine(company);
            Console.WriteLine(college);



        }


    }
}