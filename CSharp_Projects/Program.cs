using System;

namespace CSharp_Projects
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World !");
            int age; // Declaration of a variable
            Console.Write("Please Enter Your Age : ");
            age = Convert.ToInt32(Console.ReadLine());


            if (age >= 18)
            {
                Console.WriteLine($"Congratulations You'r eligible to Vote as you'r of age {age}");
            }
            else
            {
                Console.WriteLine($"Sorry...! \n\t You are not Eligible to vote yet as you are of age {age}");
            }
            */

            string textAge = "-27";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            Console.WriteLine($"int Data type is : {age.GetType()} & its Value is : {age}");
            Console.WriteLine($"int Max Value is : {int.MaxValue}");
            Console.WriteLine($"int Min Value is : {int.MinValue} \n");



            string textBigNumber = "567898765432345678";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);
            //long bigNumber = 567898765432345678L;
            Console.WriteLine($"long Data type is : {bigNumber.GetType()} & its Value is : {bigNumber}");
            Console.WriteLine($"Long Max Value is : {long.MaxValue}");
            Console.WriteLine($"Long Min Value is : {long.MinValue} \n");

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);
            //double randomDouble = 3456.456789012345678D;
            Console.WriteLine($"double Data type is : {negative.GetType()} & its Value is : {negative}");
            Console.WriteLine($"double Max Value is : {double.MaxValue}");
            Console.WriteLine($"double Min Value is : {double.MinValue} \n");

            string textPrecision = "456.4723156784";
            float precision = Convert.ToSingle(textPrecision);
            //float precision = 456.4723156784F;
            Console.WriteLine(precision);
            Console.WriteLine($"float data type is : {precision.GetType()} & its Value is : {precision}");
            Console.WriteLine($"Float Max Value is : {float.MaxValue}");
            Console.WriteLine($"Float Min Value is : {float.MinValue} \n");


            string textMoney = "14.59";
            decimal money = Convert.ToDecimal(textMoney);
            //decimal money = 3456.5667823456789M;
            Console.WriteLine($"decimal Data type is : {money.GetType()} & its Value is : {money}");
            Console.WriteLine($"decimal Max Value is : {double.MaxValue}");
            Console.WriteLine($"decimal Min Value is : {double.MinValue} \n");

            int firstNumber, secondNumber;
            Console.Write("Please Enter the First Number : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());  // 10
            Console.Write("Please enter the Second Number : ");
            secondNumber = Convert.ToInt32(Console.ReadLine()); // 3

            Console.WriteLine($"The division (/) returns the int Value : {firstNumber / secondNumber}");
            Console.WriteLine($"The division (/) is converted to double  : {Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber)}");
            Console.WriteLine($"The division (/) is converted to decimal  : {Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber)}");
            Console.WriteLine($"The division (/) is converted to float  : {Convert.ToSingle(firstNumber) / Convert.ToSingle(secondNumber)}");
            Console.WriteLine($"The Modulus division (%) output is Remainder : {firstNumber % secondNumber}");



            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Thank You for checking... \n Please come back later.");
            Console.Read();
        }
    }
}
