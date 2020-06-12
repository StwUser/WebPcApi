using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPcApi.Interfaces;
using WebPcApi.Models;

namespace WebPcApi.Implementation
{
    public class PcsRepository : IPcsRepository
    {
        private readonly PcsContext _db;

        public PcsRepository(PcsContext context)
        {
            _db = context;
        }

        // Screens

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

        public void AddScreen(Screen screen)
        {
            _db.Add(screen);
            _db.SaveChanges();
        }

        public void DeleteScreen(int id)
        {
            var screen = _db.Screens
                .Where(s => s.Id == id)
                .FirstOrDefault<Screen>();
            _db.Screens.Remove(screen);
            _db.SaveChanges();
        }

        public void UpdateScreen(int id, Screen screen)
        {
            var screenOld = _db.Screens
                .Where(s => s.Id == id)
                .FirstOrDefault<Screen>();
            screenOld.Name = screen.Name;
            screenOld.Sn = screen.Sn;
            _db.SaveChanges();
        }

        // Motherboards

        public Motherboard GetMotherboard(int id)
        {
            var motherboard = _db.Motherboards
                .Where(s => s.Id == id)
                .FirstOrDefault<Motherboard>();
            return motherboard;
        }

        public IEnumerable<Motherboard> GetMotherboards()
        {
            return _db.Motherboards;
        }

        public void AddMotherboard(Motherboard motherboard)
        {
            _db.Add(motherboard);
            _db.SaveChanges();
        }

        public void DeleteMotherboard(int id)
        {
            var motherboard = _db.Motherboards
                .Where(s => s.Id == id)
                .FirstOrDefault<Motherboard>();
            _db.Motherboards.Remove(motherboard);
            _db.SaveChanges();
        }

        public void UpdateMotherboard(int id, Motherboard motherboard)
        {
            var motherboardOld = _db.Motherboards
                .Where(s => s.Id == id)
                .FirstOrDefault<Motherboard>();
            motherboardOld.Name = motherboard.Name;
            motherboardOld.Sn = motherboard.Sn;
            _db.SaveChangesAsync();
        }

        // Memories

        public Memory GetMemory(int id)
        {
            var memory = _db.Memories
                .Where(s => s.Id == id)
                .FirstOrDefault<Memory>();
            return memory;
        }

        public IEnumerable<Memory> GetMemories()
        {
            return _db.Memories;
        }

        public void AddMemory(Memory memory)
        {
            _db.Add(memory);
            _db.SaveChanges();
        }

        public void DeleteMemory(int id)
        {
            var memory = _db.Memories
                .Where(s => s.Id == id)
                .FirstOrDefault<Memory>();
            _db.Memories.Remove(memory);
            _db.SaveChanges();
        }

        public void UpdateMemory(int id, Memory memory)
        {
            var memoryOld = _db.Memories
                .Where(s => s.Id == id)
                .FirstOrDefault<Memory>();
            memoryOld.Name = memory.Name;
            memoryOld.Sn = memory.Sn;
            _db.SaveChanges();
        }
    }
}
