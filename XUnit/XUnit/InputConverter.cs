using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit
{
    public class InputConverter
    {
        public double ConvertInputToNumber(string argTextInput)
        {
            double convertednum;

            bool num = double.TryParse(argTextInput, out convertednum);
            if (!num) throw new ArgumentException("Expected a numeric value!");
            return convertednum;
        }
    }
}
