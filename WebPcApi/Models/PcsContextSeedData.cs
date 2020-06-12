using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPcApi.Models
{
    public class PcsContextSeedData
    {
        private PcsContext _context;

        public PcsContextSeedData(PcsContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!_context.Screens.Any())
            {
                var sc1 = new Screen();
                sc1.Name = "Sony";
                sc1.Sn = "xn090807";

                _context.Screens.Add(sc1);

                var sc2 = new Screen();
                sc2.Name = "Lg";
                sc2.Sn = "snR987";

                _context.Screens.Add(sc2);

                var sc3 = new Screen();
                sc3.Name = "Panasonic";
                sc3.Sn = "ps45673";

                _context.Screens.Add(sc3);

                await _context.SaveChangesAsync();
            }

            if (!_context.Motherboards.Any())
            {
                var sc1 = new Motherboard();
                sc1.Name = "Asus";
                sc1.Sn = "as99073";

                _context.Motherboards.Add(sc1);

                var sc2 = new Motherboard();
                sc2.Name = "Hr47";
                sc2.Sn = "h33445";

                _context.Motherboards.Add(sc2);

                var sc3 = new Motherboard();
                sc3.Name = "Intel";
                sc3.Sn = "i77833";

                _context.Motherboards.Add(sc3);

                await _context.SaveChangesAsync();
            }

            if (!_context.Memories.Any())
            {
                var sc1 = new Memory();
                sc1.Name = "Corsar";
                sc1.Sn = "cs44837";

                _context.Memories.Add(sc1);

                var sc2 = new Memory();
                sc2.Name = "Kilser";
                sc2.Sn = "kl44739";

                _context.Memories.Add(sc2);

                var sc3 = new Memory();
                sc3.Name = "DDr3";
                sc3.Sn = "dr4455";

                _context.Memories.Add(sc3);

                await _context.SaveChangesAsync();
            }
        }
    }
}
