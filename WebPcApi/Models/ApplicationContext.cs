using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPcApi.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Memory> Memories { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<Screen> Screens { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();   // Create Db with first request 
        }
    }
}
