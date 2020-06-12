using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPcApi.Models;

namespace WebPcApi.Interfaces
{
    public interface IScreenRepository
    {
        IEnumerable<Screen> GetScreens();

        Screen GetScreen(int id);

        void AddScreen(Screen screen);

        void UpdateScreen(int id, Screen screen);

        void DeleteScreen(int id);
    }
}
