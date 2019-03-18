using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int answer;
            Console.WriteLine("Enter the First number:");
            var number1 = Console.ReadLine();
            int firstNum;
            if (int.TryParse(number1, out firstNum))
            {
                Console.WriteLine(firstNum);
            }
            else
            {
                Console.WriteLine("Invalid input numbers, please try again");
            }

            Console.WriteLine("Enter the Second number:");
            var number2 = Console.ReadLine();
            int secondNum;
            if (int.TryParse(number2, out secondNum))
            {
                Console.WriteLine(secondNum);
            }
            else
            {
                Console.WriteLine("Invalid input numbers, please try again");

            }


            Console.WriteLine("Enter the operation ( + , - , * , / ) ");
            string operation = Console.ReadLine();

            if (operation == "*")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " * " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid operation selected, please try again.");     
                Console.ReadLine();
            }

        }
    }
}
