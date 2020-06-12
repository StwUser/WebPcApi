using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPcApi.Interfaces;
using WebPcApi.Models;

namespace WebPcApi.Implementation
{
    public class ScreenService : IScreenService
    {
        private readonly IPcsRepository _screenRepository;
        private ILogger<ScreenService> _logger;

        public ScreenService(IPcsRepository screenRepository, ILogger<ScreenService> logger)  //DI
        {
            _screenRepository = screenRepository;
            _logger = logger;
        }

        public Screen GetScreen(int id)
        {
            try
            {
                return _screenRepository.GetScreen(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetScreen: excteption was thrown.");
                throw;
            }
        }

        public IEnumerable<Screen> GetScreens()
        {
            try
            {
                return _screenRepository.GetScreens();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetScreens: excteption was thrown.");
                throw;
            }
        }

        public void AddScreen(Screen screen)
        {
            try
            {
                _logger.LogInformation($"AddScreen: Screen.Id {screen.Id}, Screen.Name {screen.Name}, Screen.Sn {screen.Sn}");
                _screenRepository.AddScreen(screen);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AddScreen: excteption was thrown.");
                throw;
            }
        }

        public void DeleteScreen(int id)
        {
            try
            {
                _screenRepository.DeleteScreen(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DeleteScreens: excteption was thrown.");
                throw;
            }
        }

        public void UpdateScreen(int id, Screen screen)
        {
            try
            {
                _screenRepository.UpdateScreen(id, screen);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UpdateScreen: excteption was thrown.");
                throw;
            }
        }
    }
}
