using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_b2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap email cua ban: ");
            string email = Console.ReadLine();
            while (!validateemail(email))
            {
                Console.WriteLine("email khong hop le");
                Console.WriteLine("email phai co dinh dang : exp@abc.def");
                Console.WriteLine("Nhap email cua ban: ");
                email = Console.ReadLine();
            }
            Console.WriteLine("email hop le");
      
            Console.ReadKey();
        }
        static bool validateemail(string email)
        {
            int count = 0;

            foreach (char c in email)
            {
                if (c == '@')
                {
                    count++;
                }
            }
            if (count > 1)
            {
                Console.WriteLine("Email khong dung dinh dang");
            }
            if (email.IndexOf("@") > 0 || email.IndexOf("@") < email.Length - 1)
            {
                if (email.IndexOf(".") > 0 || email.IndexOf(".") < email.Length - 1)
                {
                    if (email.IndexOf("@") < email.IndexOf("."))
                    {
                        if (!email.Contains(" "))
                        {
                            int Countdot = email.Length - email.IndexOf(".") - 1;
                            int countA = email.IndexOf(".") - email.IndexOf("@") - 1;
                            if ((Countdot > 0 && Countdot < 4) && (countA > 0 && countA < 8))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
