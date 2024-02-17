using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.calcualtor
{
    public static class summation
    {
        // this method for adding the elements
        /// <summary>
        /// this method for adding the elements
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>double value</returns>
        public static double Add(double x,double y) {
            double firstparamatter = x;
            double secondparamatter = y;
            double answer =firstparamatter + secondparamatter;
            return answer;         
        }
        // this method for substraction the elements 
        /// <summary>
        /// this method for substraction the elements 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>double value</returns>
        public static double Substraction(double x, double y)
        {
            double firstparamatter = x;
            double secondparamatter = y;
            double answer = firstparamatter - secondparamatter;
            return answer;
        }

        //this for division
        /// <summary>
        /// this for division
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>double value</returns>
        public static double Divide(double x, double y)
        {
            double firstparamatter = x;
            double secondparamatter = y;
            double answer = firstparamatter / secondparamatter;
            return answer;
        }
        // this for multiplication
        /// <summary>
        /// this method  for multiplication the elements
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>double value</returns>
        public static double Multiplay(double x, double y)
        {
            double firstparamatter = x;
            double secondparamatter = y;
            double answer = firstparamatter * secondparamatter;
            return answer;
        }


    }
}
