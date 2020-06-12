using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPcApi.Interfaces;
using WebPcApi.Models;

namespace WebPcApi.Implementation
{
    public class MemoryService : IMemoryService
    {
        private readonly IPcsRepository _pcsRepository;

        public MemoryService(IPcsRepository screenRepository)  //DI
        {
            _pcsRepository = screenRepository;
        }

        public Memory GetMemory(int id)
        {
            return _pcsRepository.GetMemory(id);
        }

        public IEnumerable<Memory> GetMemories()
        {
            return _pcsRepository.GetMemories();
        }

        public void AddMemory(Memory memory)
        {
            _pcsRepository.AddMemory(memory);
        }

        public void DeleteMemory(int id)
        {
            _pcsRepository.DeleteMemory(id);
        }

        public void UpdateMemory(int id, Memory memory)
        {
            _pcsRepository.UpdateMemory(id, memory);
        }
    }
}
