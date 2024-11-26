using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Operatoren
    {
        public Operatoren() 
        {
            Console.WriteLine("Please enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number (can be a X,XX)");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What do you want to do with the numbers?");
            Console.WriteLine("Addition; Subtraction; Multiplication; Division; Modulus; Increment; Decrement");
            string input = Console.ReadLine();
            if(input == "Addition")
            {
                double sum = num1 + num2;
                Console.WriteLine(sum);
            }
            else if (input == "Subtraction")
            {
                double sum = num1 - num2;
                Console.WriteLine(sum);
            }
            else if (input == "Multiplication")
            {
                double sum = num1 * num2;
                Console.WriteLine(sum);
            }
            else if (input == "Division")
            {
                double sum = num1 / num2;
                Console.WriteLine(sum);
            }
            else if (input == "Modulus")
            {
                double sum = num1 % num2;
                Console.WriteLine(sum);
            }
            else if (input == "Increment")
            {
                num1++;
                num2++;
                Console.WriteLine(num1 + " " + num2);
            }
            else if (input == "Decrement")
            {
                num1--;
                num2--;
                Console.WriteLine(num1 + " " + num2);
            }
            else
            {
                Console.WriteLine("Unknown command");
            }

        }
    }
}
/*
 * Operator	Name	    Description	                     Example
 * +	Addition	    Adds together two values	     x + y	
 * -	Subtraction	    Subtracts one value from another x - y	
 * *	Multiplication	Multiplies two values	         x * y	
 * /	Division	    Divides one value by another	 x / y	
 * %	Modulus	        Returns the division remainder	 x % y	
 * ++	Increment	    Increases the value of a variable by 1	x++	
 * --	Decrement	    Decreases the value of a variable by 1	x--	
*/