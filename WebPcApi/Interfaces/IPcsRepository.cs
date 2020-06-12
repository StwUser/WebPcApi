using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPcApi.Models;

namespace WebPcApi.Interfaces
{
    public interface IPcsRepository
    {
        // Screens

        IEnumerable<Screen> GetScreens();

        Screen GetScreen(int id);

        void AddScreen(Screen screen);

        void UpdateScreen(int id, Screen screen);

        void DeleteScreen(int id);

        // Motherbpards
        IEnumerable<Motherboard> GetMotherboards();

        Motherboard GetMotherboard(int id);

        void AddMotherboard(Motherboard motherboard);

        void UpdateMotherboard(int id, Motherboard motherboard);

        void DeleteMotherboard(int id);

        // Memories
        IEnumerable<Memory> GetMemories();

        Memory GetMemory(int id);

        void AddMemory(Memory memory);

        void UpdateMemory(int id, Memory memory);

        void DeleteMemory(int id);
    }
}
