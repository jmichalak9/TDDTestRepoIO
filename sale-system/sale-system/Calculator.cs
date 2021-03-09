using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sale_system
{
    public class Calculator
    {
        private static int DelimitersLength(string number)
        {
            int length = 0;
            for(int i=2;i<number.Length;i++)
            {
                if (((int)number[i] > 47) && ((int)number[i] < 58)) break;
                length++;
            }
            return length;
        }

        public static int Add(string numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            List<string> separators = new List<string> { ",", "\n" };
            if (numbers.Length > 2 && (numbers[0] == '/' && numbers[1] == '/'))
            {
                int delimitersLength = DelimitersLength(numbers);
                string delimiters = numbers.Substring(2, delimitersLength);
                separators.AddRange(delimiters.Split('[', ']'));
                numbers = numbers.Substring(2 + delimitersLength);
            }
            int num = 0;
            foreach (string number in numbers.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                num += int.Parse(number);
            }
            return num;

        }
    }
}
