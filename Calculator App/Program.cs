using System;

namespace Calculator_App
{
    public class Program
    {
        public static int readIntFromConsole(string message)
        {
            return Convert.ToInt32(readStringFromConsole(message));
        }

        public static string readStringFromConsole(string message)
        {
            Console.Write(Environment.NewLine + message);
            return Console.ReadLine();
        }

        public static bool CheckConditions(string number, string words, string symbol, string geekWord, string operatorInput)
        {
            if (operatorInput.Contains(number) || operatorInput.ToLower().Contains(words) || operatorInput.Contains(symbol) || operatorInput.ToLower().Contains(geekWord))
                return true;
            return false;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t~~~~~~~~~~ Welcome to My Calculator App ~~~~~~~~~~\n");
            bool isRepeat = true;
            while (isRepeat)
            {

                int firstNumber = readIntFromConsole("Enter Your First Number : ");

                Console.WriteLine(Environment.NewLine + "\tNow Choose Your Operator to Calculate.");
                Console.WriteLine("1. plus (+)");
                Console.WriteLine("2. minus (-)");
                Console.WriteLine("3. multiplication (*)");
                Console.WriteLine("4. division (/)");
                Console.WriteLine("5. modulusDiv (%)");

                string choosenOperator = readStringFromConsole("Enter Your Operator : ");
                bool validInput = true;
                int secondNumber = readIntFromConsole("Enter Your Second Number : ");


                double result = 0.0;

                if (CheckConditions("1", "plus", "+", "add", choosenOperator))
                {
                    result = firstNumber + secondNumber;
                    choosenOperator = "+";
                }
                else if (CheckConditions("2", "minus", "-", "sub", choosenOperator))
                {
                    result = firstNumber - secondNumber;
                    choosenOperator = "-";
                }
                else if (CheckConditions("3", "multiplication", "*", "mul", choosenOperator))
                {
                    result = firstNumber * secondNumber;
                    choosenOperator = "*";
                }
                else if (CheckConditions("4", "division", "/", "div", choosenOperator))
                {
                    result = (double)firstNumber / secondNumber;
                    choosenOperator = "/";
                }
                else if (CheckConditions("5", "modulusDiv", "%", "mod", choosenOperator))
                {
                    result = firstNumber % secondNumber;
                    choosenOperator = "%";
                }
                else
                {
                    validInput = false;
                }

                if (validInput)
                {
                    Console.Write(Environment.NewLine +
                    $"The Result of {firstNumber} {choosenOperator} {secondNumber} is : {string.Format("{0:0.0#}", result)}");
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "\tSorry, Choosen Wrong Operator. Please Try Again...");
                }

                Console.Write(Environment.NewLine + "\n\tDo You Want to Continue the Calculation ?  :");
                string repeatCal = Console.ReadLine();

                if ((repeatCal.ToLower().Contains("y") || repeatCal.ToLower().Contains("")) && !repeatCal.ToLower().Contains("n"))
                {
                    isRepeat = true;
                }
                else
                {
                    isRepeat = false;
                    Console.Clear();
                }

                //isRepeat = repeatCal.ToLower().Contains("y");

            }

            Console.WriteLine(Environment.NewLine + "\n\n~~~~~~~~ Thank You For Using Our Calculator ~~~~~~~~");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
