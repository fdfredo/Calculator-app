using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassJoe
{
    public class Operations
    {
        public double inputA;
        public double inputB;
        public double Addition()
        {
            return inputA + inputB;
        }
        public double Subtraction()
        {
            return inputA - inputB;
        }
        public double Multiplication()
        {
            return inputA * inputB;
        }
        public double Division()
        {
            return inputA / inputB;
        }

        public static bool PerformAgain()
        {
            while (true) 
            {
                CalculatorMessages.MessageMethod(7);
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    return true;
                else
                    return false;
            }
        }
    }
}

        /*public static (bool, int) IsValidNumber(string input1)
        {
            bool success = int.TryParse(input1, out int num);

            if (!success)
                Console.WriteLine("Please enter a valid number");
            else
                success = true;
            return (success, num);*/

