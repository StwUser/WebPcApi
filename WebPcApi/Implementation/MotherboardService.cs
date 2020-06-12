using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPcApi.Interfaces;
using WebPcApi.Models;

namespace WebPcApi.Implementation
{
    public class MotherboardService : IMotherboardService
    {
        private readonly IPcsRepository _pcsRepository;

        public MotherboardService(IPcsRepository screenRepository)  //DI
        {
            _pcsRepository = screenRepository;
        }

        public Motherboard GetMotherboard(int id)
        {
            return _pcsRepository.GetMotherboard(id);
        }

        public IEnumerable<Motherboard> GetMotherboards()
        {
            return _pcsRepository.GetMotherboards();
        }

        public void AddMotherboard(Motherboard motherboard)
        {
            _pcsRepository.AddMotherboard(motherboard);
        }

        public void DeleteMotherboard(int id)
        {
            _pcsRepository.DeleteMotherboard(id);
        }

        public void UpdateMotherboard(int id, Motherboard motherboard)
        {
            _pcsRepository.UpdateMotherboard(id, motherboard);
        }
    }
}

