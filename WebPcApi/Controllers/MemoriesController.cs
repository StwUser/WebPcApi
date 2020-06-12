using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebPcApi.Interfaces;
using WebPcApi.Models;

namespace WebPcApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MemoriesController : Controller
    {
        private readonly IMemoryService _pcsService;

        public MemoriesController(IMemoryService memoryService)
        {
            _pcsService = memoryService;
        }

        [HttpGet]
        public IEnumerable<Memory> GetMemories()
        {
            return _pcsService.GetMemories();
        }

        [HttpGet("{id}")]
        public Memory GetMemory(int id)
        {
            return _pcsService.GetMemory(id);
        }

        [HttpPost("{id}")]
        public IActionResult CreateMemory([FromBody]Memory memory)
        {
            _pcsService.AddMemory(memory);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMemory(int id, [FromBody]Memory memory)
        {
            _pcsService.UpdateMemory(id, memory);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMemory(int id)
        {
            _pcsService.DeleteMemory(id);
            return Ok();
        }
    }
}