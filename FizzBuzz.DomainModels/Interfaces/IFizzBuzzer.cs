using System.Collections.Generic;

namespace FizzBuzz.DomainModels.Interfaces
{
    public interface IFizzBuzzer : IService
    {
        string FizzBuzzIt(IEnumerable<string> values);
    }
}
