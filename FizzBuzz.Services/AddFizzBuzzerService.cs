using FizzBuzz.DomainModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FizzBuzz.Services
{
    public class AddFizzBuzzerService : IAddFizzBuzzerService
    {
        public string FizzBuzzIt(IEnumerable<string> values)
        {
            var list = new List<int>();
            foreach (var val in values)
            {
                if (int.TryParse(val, NumberStyles.Integer, CultureInfo.CurrentCulture, out int ayelu))
                {
                    list.Add(ayelu);
                }
            }

            return list.Any() && list.Sum() % 2 == 0
                ? "Fizz-Buzz"
                : string.Format("The sum of {0} is odd{1}", string.Join("+", list), Environment.NewLine);
        }
        
    }
}
