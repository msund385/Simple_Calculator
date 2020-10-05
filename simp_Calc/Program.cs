using System;
using System.IO.Pipes;

namespace simp_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, answer = 0;
            string operand;

            Console.Write("Please enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter operand <+,-,*,/>: ");
            operand = Console.ReadLine();

            Console.Write("Please enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operand)
            {

                case "+":
                    answer = num1 + num2;
                    break;

                case "-":
                    answer = num1 - num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;
            }


            Console.WriteLine("Your answer is: {0}{1}{2} = {3}", num1, operand, num2, answer);
        }
    }
}

            
            
                
            
        
   

