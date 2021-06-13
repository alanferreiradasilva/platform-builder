using Microsoft.AspNetCore.Mvc;
using PlatformBuilder.Abstractions.Services;

namespace PlatformBuilder.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalindromeController : ControllerBase
    {
        private readonly IPalindromeService _service;

        public PalindromeController(IPalindromeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetIsPalindrome(string value)
        {
            return Ok(_service.IsPalindrome(value));
        }
    }
}
