using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPcApi.Models
{
    public class PcsContext : DbContext
    {
        public PcsContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Screen> Screens { get; set; }

        public DbSet<Memory> Memories { get; set; }

        public DbSet<Motherboard> Motherboards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; Database = PcsDb; ";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
