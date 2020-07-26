using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Contexts
{
    public class ErpContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\Local;Database=Gurmen; Uid=mehmet;Pwd=QAZwsx2!;");
        }

        public DbSet<Personel> Personel { get; set; }
        public DbSet<Izin> Izin { get; set; }

      
    }
}
