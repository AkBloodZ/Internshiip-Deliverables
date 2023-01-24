using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit
{
    public class CalcEngine
    {
        public double Calculate(string Operation, double firstnum, double secondnum)
        {
            double res;
            switch(Operation.ToLower())
            {
                case "+":
                case "add":
                    res = firstnum + secondnum; 
                    break;

                case "-":
                case "sub":
                    res = secondnum - firstnum;
                    break;

                case "*":
                case "mul":
                    res = firstnum * secondnum;
                    break;

                case "/":
                case "div":
                    res = secondnum / firstnum;
                    break;

                default:
                    throw new InvalidOperationException("Specified Operation is not recognized!");
            }
            return res;
        }
    }
}
