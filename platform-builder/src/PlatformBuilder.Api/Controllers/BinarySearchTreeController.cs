using Microsoft.AspNetCore.Mvc;
using PlatformBuilder.Abstractions.Services;

namespace PlatformBuilder.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BinarySearchTreeController : ControllerBase
    {
        private readonly IBinarySearchTreeService _service;

        public BinarySearchTreeController(IBinarySearchTreeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetFindWithValue(int value)
        {
            var root = _service.GetNode();

            var name = _service.FindWithValue(root, value);

            return Ok(string.IsNullOrWhiteSpace(name) ? string.Empty : name);
        }
    }
}
