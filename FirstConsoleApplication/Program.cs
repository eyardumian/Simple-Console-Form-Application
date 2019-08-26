using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //User prompts, variable assignments, and input conversions.
            Console.Write("Enter a whole number.");
            int FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another whole number.");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an operation symbol(+, -, or x)");
            string Operation = Console.ReadLine();
            int Answer;

            //Determine which operation to use.
            if (Operation == "+")
            {
                Answer = FirstNum + SecondNum;
                Console.WriteLine(Answer);
            }
            else if (Operation == "-")
            {
                Answer = FirstNum - SecondNum;
                Console.WriteLine(Answer);
            }
            else if (Operation == "x")
            {
                Answer = FirstNum * SecondNum;
                Console.WriteLine(Answer);
            }
            //Display error message if user input is incorrect.
            else
            {
                Console.WriteLine("Wrong input.");
            }
        }
    }
}
