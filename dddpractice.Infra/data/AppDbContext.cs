using dddpractice.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddpractice.Infra.data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<Car> cars { get; set; }


        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
