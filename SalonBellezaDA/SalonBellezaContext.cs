using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SalonBellezaBO;

namespace SalonBellezaDA
{
	public class SalonBellezaContext : DbContext
	{
		public SalonBellezaContext() : base("name=EFConnectionString")
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<SalonBellezaContext, Migrations.Configuration>("EFConnectionString"));
		}
		public DbSet<cita> Citas { get; set; }
		public DbSet<cliente> Clientes { get; set; }
		public DbSet<empleado> Empleados { get; set; }
		public DbSet<equipo> Equipos { get; set; }
		public DbSet<Servicio> Servicios { get; set; }
		public DbSet<material> Materiales { get; set; }
        public DbSet<TipoServicio> TiposServicios { get; set; }
		

	}


}	
	
