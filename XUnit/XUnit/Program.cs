using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter input = new InputConverter();
                CalcEngine calculator = new CalcEngine();

                double firstnum = input.ConvertInputToNumber(Console.ReadLine());
                double secondnum = input.ConvertInputToNumber(Console.ReadLine());

                string operation = Console.ReadLine();

                double res = calculator.Calculate(operation, firstnum, secondnum);

                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
