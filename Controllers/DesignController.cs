using dressed_backend.Models.DTOs;
using dressed_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace dressed_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignController : ControllerBase
    {
        private readonly DesignService _service;

        public DesignController(DesignService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var designs = await _service.GetAllAsync();
            return Ok(designs);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDesignDto createDto)
        {
            await _service.AddAsync(createDto);
            return CreatedAtAction(nameof(GetAll), null, new { message = "Design created successfully!" });
        }
    }
}
