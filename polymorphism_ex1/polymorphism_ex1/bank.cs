using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism_ex1
{
    internal class bank
    {
        private long account_no;
        private string ifsc_code;
        private string accholder_name;
        private long phone_no;
        private int initial_amount;
        private int atm_pin;


        public bank(long acc_no, string ifsc, string name, long mobile, int amount, int pin)
        {
            account_no = acc_no;
            ifsc_code = ifsc;
            accholder_name = name;
            phone_no = mobile;
            initial_amount = amount;
            atm_pin = pin;
        }

        //bank transfer
        public void deposit(long acc_no, string ifsc, int amount)
        {
            if (acc_no == account_no && ifsc == ifsc_code)
            {
                initial_amount += amount;
                Console.WriteLine("Bank transfer : " + initial_amount);
            }
            else
            {
                Console.WriteLine("Account no or ifsc code is wrong");
            }
        }

        //ATM
        public void deposit(long accno, int atmpin, int deposit)
        {
            if (accno == account_no && atmpin == atm_pin)
            {
                initial_amount += deposit;
                Console.WriteLine("ATM transfer : " + initial_amount);
            }
            else
            {
                Console.WriteLine("Invalid details");
            }
        }

        //upi transfer
        public void deposit(string name, long mobile, int deposit_amount)
        {
            if (accholder_name == name && phone_no == mobile)
            {
                initial_amount += deposit_amount;
                Console.WriteLine("UPI transfer : " + initial_amount);
            }
            else
            {
                Console.WriteLine("Invalid upi details");
            }
        }

    }
}