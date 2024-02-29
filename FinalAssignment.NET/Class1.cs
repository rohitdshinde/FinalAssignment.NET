using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.NET
{
    internal class Class1
    {
        public void Q1()
        {
           Console.WriteLine("Enter a string");
           string strr =Console.ReadLine();

            if (strr.Length >= 2)
            {
                char[] arr=strr.ToCharArray();
                char temp = arr[0];
                arr[0]= arr[strr.Length - 1];
                arr[strr.Length-1]= temp;

                string strr1=new string(arr);
                Console.WriteLine("After swapping "+strr1);
            }
            else
            {
                Console.WriteLine("plz enter atlast more charcter");
            }
        }
        public void Q2()
        {
            Console.WriteLine("Enter a number");
            int a=Convert.ToInt32(Console.ReadLine());

            int sum = 0, digit, og = a;
            while(a!=0) {
                digit = a % 10;
                sum += digit;
                a=a/10;
            }
            Console.WriteLine($"sum of every number{og}: {sum}");

        }
        public void Q3() //without using recursion
        {
            Console.WriteLine("Enter a Number:");
            int n=Convert.ToInt32(Console.ReadLine());
            int temp = n, sum = 0;

            while(temp!=0)
            {
                int digit = temp % 10;
                sum = sum * 10 + digit;
                temp = temp/10;
            }
            if(n==sum)
            {
                Console.WriteLine("number is paildrome");
            }
            else
            {
                Console.WriteLine("number is not paildrome");
            }
        }
        public void Q4()
        {
            try
            {
                Console.WriteLine("Enter a number");
                double number=Convert.ToDouble(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentException("Number is Negative");
                }
                double n=Math.Sqrt(number);
                Console.WriteLine($"The square root of {number} is {n}");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Invalid input"+ex);
            }


        }
    }
}
