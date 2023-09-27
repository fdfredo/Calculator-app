using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassJoe
{
    class CalculatorMessages
    {
        const string input1 = "Enter the First Number";
        const string input2 = "Enter the Second Number";

        const string errorInput = "Error Occured:";
        const string errorMessage = "Please enter a valid Number";
        const string result = "Result:";
        const string errorInput2 = "Cannot divide by zero(0), please enter a valid Number";

        const string operation = "what do you want to do,(-,*,+,/)";
        const string endApp = ("Do you want to perform another operation [Y/N]?");

        public static void MessageMethod(short? MessageIndex, double? results = null)
        {
            switch (MessageIndex)
            {
                case 0:
                    Console.WriteLine(input1);
                    break;
                case 1:
                    Console.WriteLine(input2);
                    break;
                case 2:
                    Console.WriteLine(errorInput);
                    break;
                case 3:
                    Console.WriteLine(errorMessage);
                    break;
                case 4:
                    Console.WriteLine(result + results);
                    break;
                case 5:
                    Console.WriteLine(errorInput2);
                    break;
                case 6:
                    Console.WriteLine(operation);
                    break;
                case 7:
                    Console.WriteLine(endApp);
                    break;
            }
        }
    }
}
