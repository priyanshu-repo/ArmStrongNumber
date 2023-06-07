using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmStrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter the number to check whether the number is armstrong or not :- ");
            int num = int.Parse(Console.ReadLine());

            int temp = num, sum = 0, rem;
            while (temp > 0)
            {
                rem = temp % 10;
                sum = sum + (rem * rem * rem);
                temp = temp / 10;
            }
           var result=  sum == num ? $"{num} is a armstrong number " : $"{num} is not a armstrong number";
            Console.WriteLine(result);

            // added this line now create new branch
            Console.WriteLine("this is added for testing clone");
            Console.ReadLine(); 
        }
    }
}
