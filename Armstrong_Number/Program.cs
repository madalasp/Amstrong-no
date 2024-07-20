using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no, temp, rem, sum=0;
            Console.WriteLine("Enter a Number:");
            no=int.Parse(Console.ReadLine());
            temp = no;
            while(no > 0)
            {
                rem = no % 10;
                sum = sum + (rem * rem * rem);
                no = no / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("it is Armstrong Number");
            }
            else
            {
                Console.WriteLine("it is not Armstrong Number");
            }
            Console.ReadLine();
        }
    }
}
