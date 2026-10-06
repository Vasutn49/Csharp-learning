using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class employee
    {
        //instant variable
        public int employee_id;
        public string employee_name;

        public string employee_email;

        public string company_name;

        public void employee_details()
        {
            Console.WriteLine(employee_id);
            Console.WriteLine(employee_name);
            Console.WriteLine(employee_email);
            Console.WriteLine(company_name);

        }



    }
}