using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using floreria.Models;

namespace WebAppVet.Data
{
    public class FloreriaDbContext : DbContext
    {
        public FloreriaDbContext() :base("floreria")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Devolucion> Devolucion { get; set; }
        public DbSet<Flor> Flor { get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<PedidoCab> PedidoCab { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalle { get; set; }
    }
}