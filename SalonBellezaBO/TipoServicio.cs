 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonBellezaBO
{
	public class TipoServicio
	{
		public int TipoServicioId { get; set; }
		public string Nombre { get; set; }

		public ICollection<Servicio> Servicios { get; set; }

		public virtual ICollection<equipo> equipos { get; set; }//PROPIEDAD para la asosiacion de MM
		public virtual ICollection<Servicio> servicios { get; set; }

		public TipoServicio()//contructor Para la asociasion de MM
		{
			this.equipos = new HashSet<equipo>();
			this.servicios = new HashSet<Servicio>();
		}
	}



	
}
