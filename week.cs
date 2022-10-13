using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 
public class Lesson3
{
    static void Main(string[] args)
    {


       Console.WriteLine("");
       Console.WriteLine("1. Monday");
       Console.WriteLine("2. Tuesday");
       Console.WriteLine("3. Wednesday");
       Console.WriteLine("4. Thursday");
       Console.WriteLine("5. Friday");
       Console.WriteLine("6. Saturday");
       Console.WriteLine("7. Sunday");
       Console.WriteLine("");
       //Your code goes here
       try
       {
       Console.Write("Enter the day number of the week: ");
       
       int number = int.Parse(Console.ReadLine());
       
       if (number==1)
       {
       Console.WriteLine("Today is Monday");
       }
       else if (number==2)
       {
       Console.WriteLine("Today is Tuesday");
       }
       else if (number==3)
       {
       Console.WriteLine("Today is Wednesday");
       }
       else if (number==4)
       {
       Console.WriteLine("Today is Thursday");
       }
       else if (number==5)
       {
       Console.WriteLine("Today is Friday");
       }
       else if (number==6)
       {
       Console.WriteLine("Today is Saturday");
       }
       else if (number==7)
       {
       Console.WriteLine("Today is Sunday");
       }
       else 
       {
       Console.WriteLine("Please enter a valid number from 1 to 7 ");  
       }
       }
       catch
       {
       Console.WriteLine("Something Went Wrong!....");
                       
        }
    }
