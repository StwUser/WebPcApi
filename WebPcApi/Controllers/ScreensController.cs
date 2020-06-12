using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPcApi.Interfaces;
using WebPcApi.Models;

namespace WebPcApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScreensController : Controller
    {
        private readonly IScreenService _pcsService;
        private readonly IMemoryCache _cache;

        public ScreensController(IScreenService screenService, IMemoryCache cache)
        {
            _pcsService = screenService;
            _cache = cache;
        }

        [HttpGet]
        public IEnumerable<Screen> GetScreens()
        {
            IEnumerable<Screen> result;

            if (!_cache.TryGetValue("screens", out result))
            {
                result = _pcsService.GetScreens();

                _cache.Set("screens", result, new TimeSpan(0, 2, 0));
            }

           return result;
        }

        [HttpGet("{id}")]
        public Screen GetScreen(int id)
        {
            return _pcsService.GetScreen(id);
        }

        [HttpPost("{id}")]
        public IActionResult CreateScreen([FromBody]Screen screen)
        {
            _pcsService.AddScreen(screen);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateScreen(int id, [FromBody]Screen screen)
        {
            _pcsService.UpdateScreen(id, screen);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteScreen(int id)
        {
            _pcsService.DeleteScreen(id);
            return Ok();
        }
    }
}
