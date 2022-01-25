using CargoDeliverySystemAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoDeliverySystemAPI.Data
{
    public class CargoDeliveryDBContext : DbContext, ICargoDeliveryDBContext
    {

        public CargoDeliveryDBContext(DbContextOptions<CargoDeliveryDBContext> options) : base(options)
        {

        }


        public DbSet<Carrier> Carrier { get; set; }
        public DbSet<CarrierLog> CarriersLogs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<UserCargo> UserCargos { get; set; }


        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

    }
}
