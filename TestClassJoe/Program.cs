using System.ComponentModel;
using System.Threading.Channels;

namespace TestClassJoe
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1, input2, result;
            string opp;

            do
            {
                CalculatorMessages.MessageMethod(0);
                input1 = Convert.ToDouble(Console.ReadLine());

                CalculatorMessages.MessageMethod(1);
                input2 = Convert.ToDouble(Console.ReadLine());

                Operations calculation = new Operations();
                calculation.inputA = input1;
                calculation.inputB = input2;

                    CalculatorMessages.MessageMethod(6);
                    opp = Console.ReadLine();

                    switch (opp)
                    {
                        case "+":
                            result = calculation.Addition();
                            CalculatorMessages.MessageMethod(4, result);
                            break;

                        case "-":
                            result = calculation.Subtraction();
                            CalculatorMessages.MessageMethod(4, result);
                            break;

                        case "*":
                            result = calculation.Multiplication();
                            CalculatorMessages.MessageMethod(4, result);
                            break;

                        case "/":
                            result = calculation.Division();
                            CalculatorMessages.MessageMethod(4, result);
                            break;
                    }
            } while (Operations.PerformAgain());
        }
    }
}   
