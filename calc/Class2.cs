using calc.calcualtor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.validation
{
    public  static class valid
    {

        public static string vldmethod(string[] operator_array, ref double num1, ref double num2)
        {
            string restart_operator;
            Console.WriteLine("please choose your operation ( + , - ,*,/): ");
            string operator_ = Console.ReadLine();
            int i = 0;
            bool cond = false;
            // this loop for validtion a paramatters all it
            while (cond == false)
            {
                cond = operator_array[i] == operator_;// check if operator is valid 

                // if operator isn't valid 
                if (i == 3 && cond == false)
                {
                    Console.Write("choose a valid operator: ");
                    operator_ = Console.ReadLine();
                    i = 0;
                    continue;
                }

                if (cond == false)
                {
                    i++;
                    continue;
                }
                // if operator is valid ===> complete a validtion for other paramatters: 
                else
                    set_paramatters(ref num1, ref num2);

            }
            // Adttion
            if (operator_ == "+")
            {
                double answer = summation.Add(num1, num2);
                Console.WriteLine($"your answer is: {answer}");
            }// substraction
            else if (operator_ == "-")
            {
                double answer = summation.Substraction(num1, num2);
                Console.WriteLine($"your answer is: {answer}");
            }
            //Multiplication
            else if (operator_ == "*")
            {
                double answer = summation.Multiplay(num1, num2);
                Console.WriteLine($"your answer is: {answer}");
            }
            //Division
            else if (operator_ == "/")
            {
                double answer = summation.Divide(num1, num2);
                Console.WriteLine($"your answer is: {answer}");
            }
            Console.WriteLine("if you needed to calculate another operation enter \"yes\" ");
            restart_operator = Console.ReadLine();
            return restart_operator;
        }

        internal static void set_paramatters(ref double num1, ref double num2)
        {
            bool condition = false;
            while (condition == false)
            {

                try
                {
                    // here get the first and second number
                    condition = true;
                    Console.Write("Enter first number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    num2 = double.Parse(Console.ReadLine());

                }
                // if there exception
                catch (Exception ex)
                {
                    condition = false;
                    Console.WriteLine(ex.Message);
                    continue;

                }
            }
        }

    }
}
