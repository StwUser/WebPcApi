using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPcApi.Models;

namespace WebPcApi.Interfaces
{
    public interface IMotherboardService
    {
        IEnumerable<Motherboard> GetMotherboards();

        Motherboard GetMotherboard(int id);

        void AddMotherboard(Motherboard motherboard);

        void UpdateMotherboard(int id, Motherboard motherboard);

        void DeleteMotherboard(int id);
    }
}
