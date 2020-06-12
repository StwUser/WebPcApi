using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPcApi.Models;

namespace WebPcApi.Interfaces
{
    public interface IMemoryService
    {
        IEnumerable<Memory> GetMemories();

        Memory GetMemory(int id);

        void AddMemory(Memory memory);

        void UpdateMemory(int id, Memory memory);

        void DeleteMemory(int id);
    }
}
