using FizzBuzz.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FizzBuzz.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
		private readonly IFizzBuzzer _fizzBuzzer;

        public FizzBuzzController()
        {
			_fizzBuzzer = new FizzBuzzer(); 
        }

		public FizzBuzzController(IFizzBuzzer fizzBuzzer)
        {
			_fizzBuzzer = fizzBuzzer;
        }

		[HttpGet]
		public string Get([FromQuery] IEnumerable<string> values)
		{
			var fb = _fizzBuzzer.FizzBuzzIt(values);
			return fb;
		}

		
	}
}
