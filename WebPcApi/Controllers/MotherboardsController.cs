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
    [ApiController]
    [Route("[controller]")]
    public class MotherboardsController : Controller
    {
        private readonly IMotherboardService _pcsService;

        public MotherboardsController(IMotherboardService motherboardService)
        {
            _pcsService = motherboardService;
        }

        [HttpGet]
        public IEnumerable<Motherboard> GetMotherboards()
        {
            return _pcsService.GetMotherboards();
        }

        [HttpGet("{id}")]
        public Motherboard GetScreen(int id)
        {
            return _pcsService.GetMotherboard(id);
        }

        [HttpPost("{id}")]
        public IActionResult CreateScreen([FromBody]Motherboard motherboard)
        {
            _pcsService.AddMotherboard(motherboard);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateScreen(int id, [FromBody]Motherboard motherboard)
        {
            _pcsService.UpdateMotherboard(id, motherboard);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMotherboard(int id)
        {
            _pcsService.DeleteMotherboard(id);
            return Ok();
        }
    }
}