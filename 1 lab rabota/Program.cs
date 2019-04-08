using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            for (; ; )
            {
                bool continu = true;


                Console.Write("Enter first number and press enter: ");

                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error");
                    continu = false;
                }
                if (continu == true)
                    break;
            }
            ///////////////
            for (; ; )
            {
                bool continu = true;

                Console.Write("Enter second number and press enter: ");

                try
                {
                    b = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error");

                    continu = false;
                }
                if (continu == true)
                    break;
                ///////////
            }
            Console.Write("result=" + Sum(a, b));
            Console.ReadLine();
        }
        public static int Sum(int a, int b)
        {
            return (a + b);
        }

    }
}