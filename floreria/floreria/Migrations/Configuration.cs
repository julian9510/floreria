namespace floreria.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppVet.Data.FloreriaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppVet.Data.FloreriaDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Cliente.AddOrUpdate(
                  p => p.Id,
                  new Cliente { dni = 38867855, nombre= "Julian", direccion= "StaMarta" },
                  new Cliente { dni = 35123654, nombre= "Marcos", direccion= "Oribe" },
                  new Cliente { dni = 45002156, nombre = "Pepe", direccion = "Robertone" },
                  new Cliente { dni = 38867855, nombre = "Julian", direccion = "StaMarta" },
                  new Cliente { dni = 35123654, nombre = "Marcos", direccion = "Oribe" },
                  new Cliente { dni = 45002156, nombre = "Pepe", direccion = "Robertone" }
                );
            //
        }
    }
}
