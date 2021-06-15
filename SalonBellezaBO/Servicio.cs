using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonBellezaBO
{
	public class Servicio
	{
		public int ServicioId { get; set; }
		public string Nombre { get; set; }
		public double Costo { get; set; }
		// asociacion uno a uno de tipo servicio  servicio 
		public int TipoServicioId { get; set; }
        public TipoServicio TipoServicio { get; set; }
      
	}
	
}
