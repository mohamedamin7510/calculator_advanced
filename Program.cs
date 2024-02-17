
using System;
using System.Text;
using System.Collections;
using System.Security.Cryptography;
using System.Threading.Channels;
using calc.calcualtor;
using calc.validation;
using System.Diagnostics;
using System.ComponentModel.Design;

namespace calcualtor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // this restart_operator to close outer while loop condition
            string restart_operator = "No";
            string[] operator_array = {"+","-","*","/" };
            double num1=0;
            double num2=-1;

            do// oter loop for ask you if you wanna calc another operation
            {
                restart_operator = valid.vldmethod(operator_array, ref num1, ref num2);

            }
            while (restart_operator == "yes");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("thank you for watching");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}

