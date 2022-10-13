/*
//todo: 
Enter a number: 5
5 is included in the Fibonacci Series of 10

Do you want to input another value [Y/N]: y

Enter a number: 10
10 is not included in the Fibonacci Series of 10

Do you want to input another value [Y/N]: n

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] fibonacci_series_of_10 = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            while (true)
            {
                Console.Write("Enter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                bool match = false;
                for (int i = 0; i < 10; i++)
                {
                    if (fibonacci_series_of_10[i] == n) match = true;
                }
                //included or not
                if (match)
                {
                    //included to fibonacci in the series of 10
                    Console.WriteLine(n + " is included in the Fibonacci Series of 10");
                }
                else
                {
                    //Not included to fibonacci in the series of 10
                    Console.WriteLine(n + " is not included in the Fibonacci Series of 10");
                }
                Console.Write("Do you want to input another value [Y/N]: ");
                char ch = Convert.ToChar(Console.ReadLine());
                ch = Char.ToLower(ch);
                if (ch != 'y') break;
            }

            Console.WriteLine("End of Program.");

        }
    }

}
