﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);
    internal class CalculatorClass
    {
        public Formula<String> formula;

        public Double GetSum(double num1, double num2) 
        {   
            return (num1 + num2);
        }
        public Double GetDifference(double num1, double num2) 
        { 
            return (num1 - num2); 
        }
        public Double GetProduct(double num1, double num2) 
        { 
            return (num1 * num2); 
        }
        public Double GetQoutient(double num1, double num2) 
        { 
            return (num1 / num2); 
        }

        public event Formula<double> CalculateEvent
        {
            add {
                Console.WriteLine("Added the delegate "); 
            }
            remove {
                Console.WriteLine("Removed the delegate ");
            }
        }
    }
}