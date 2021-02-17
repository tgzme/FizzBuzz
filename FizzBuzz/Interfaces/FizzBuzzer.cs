using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FizzBuzz.Interfaces
{
    public class FizzBuzzer : IFizzBuzzer
    {
        public string DivideBy(int varVal, int modVal, string text, bool precedingNewLine = false)
        {
            return varVal % modVal == 0
                ? text
                : string.Format("{0}Divided {1} by {2}", precedingNewLine ? Environment.NewLine : string.Empty,
                                varVal, modVal);
        }

        public string FizzBuzzIt(IEnumerable<string> values)
        {
            var sb = new StringBuilder();
            foreach (var val in values)
            {
                if (!int.TryParse(val, NumberStyles.Integer, CultureInfo.CurrentCulture, out int ayelu))
                {
                    sb.AppendLine("Invalid Item");
                    continue;
                }

                sb.Append(DivideBy(ayelu, 3, "Fizz"));
                sb.Append(DivideBy(ayelu, 5, "Buzz", true));
                sb.AppendLine();

            }

            return sb.ToString();
        }
    }
}
