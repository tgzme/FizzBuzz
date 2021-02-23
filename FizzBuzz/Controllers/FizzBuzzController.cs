using FizzBuzz.DomainModels.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FizzBuzz.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
    public class FizzBuzzController : ControllerBase
    {
		private readonly IAddFizzBuzzerService _addFizzBuzzerService;
		private readonly IDivideFizzBuzzerService _divideFizzBuzzerService;
				
		public FizzBuzzController(IDivideFizzBuzzerService divideFizzBuzzerService, IAddFizzBuzzerService addFizzBuzzerService)
		{
			_divideFizzBuzzerService = divideFizzBuzzerService;
			_addFizzBuzzerService = addFizzBuzzerService;			
		}		

		[HttpGet]
		public string Get([FromQuery] IEnumerable<string> values)
		{
			var fb = _divideFizzBuzzerService.FizzBuzzIt(values);
			return fb;
		}

		[HttpGet]
		public string Divide([FromQuery] IEnumerable<string> values)
		{
			var fb = _divideFizzBuzzerService.FizzBuzzIt(values);
			return fb;
		}

		[HttpGet]
		public string Add([FromQuery] IEnumerable<string> values)
		{
			var fb = _addFizzBuzzerService.FizzBuzzIt(values);
			return fb;
		}
	}
}
