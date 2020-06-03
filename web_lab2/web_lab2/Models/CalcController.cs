using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_lab2.Models;

namespace web_lab2.Models
{
    public class Calc
    {
        public double first_value { get; set; }
        public double second_value { get; set; }
        public string operation { get; set; }

        public Calc()
        {

        }

        public Calc(double firstValue, double secondValue, string Operation)
        {
            first_value = firstValue;
            second_value = secondValue;
            operation = Operation;
        }

        public double toCalc()
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = first_value + second_value;
                    break;
                case "-":
                    result = first_value - second_value;
                    break;
                case "*":
                    result = first_value * second_value;
                    break;
                case "/":
                    result = first_value / second_value;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}