using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPcApi.Interfaces;
using WebPcApi.Models;

namespace WebPcApi.Implementation
{
    public class ScreenRepository : IScreenRepository
    {
        private readonly PcsContext _db;

        public ScreenRepository(PcsContext context)
        {
            _db = context;
        }

        public Screen GetScreen(int id)
        {
            var screen = _db.Screens
                .Where(s => s.Id == id)
                .FirstOrDefault<Screen>();
            return screen;
        }

        public IEnumerable<Screen> GetScreens()
        {
            return _db.Screens;
        }

        public async void AddScreen(Screen screen)
        {
            _db.Add(screen);
            await _db.SaveChangesAsync();
        }

        public async void DeleteScreen(int id)
        {
            var screen = _db.Screens
                .Where(s => s.Id == id)
                .FirstOrDefault<Screen>();
            _db.Screens.Remove(screen);
            await _db.SaveChangesAsync();
        }

        public async void UpdateScreen(int id, Screen screen)
        {
            var screenOld = _db.Screens
                .Where(s => s.Id == id)
                .FirstOrDefault<Screen>();
            screenOld.Name = screen.Name;
            screenOld.Sn = screen.Sn;
            await _db.SaveChangesAsync();
        }
    }
}
