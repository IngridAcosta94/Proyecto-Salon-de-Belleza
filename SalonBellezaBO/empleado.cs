using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonBellezaBO
{
	public class empleado
	{
		public int EmpleadoId { get; set; }
		public String Nombre { get; set; }
		public string Apellido { get; set; }
		public int edad { get; }
		public DateTime? Birthday { get; set; }
		public string Direccion { get; set; }
		public bool? Genero { get; set; }
		public string Telefono { get; set; }
		public string correo { get; set; }
	}
}
