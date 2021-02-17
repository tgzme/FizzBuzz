using System.Collections.Generic;

namespace FizzBuzz.Interfaces
{
    public interface IFizzBuzzer
    {
        public string DivideBy(int varVal, int modVal, string text, bool precedingNewLine);
        public string FizzBuzzIt(IEnumerable<string> values);
    }
}
