using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonBellezaBO
{
	public class cliente 
	{
		public int ClienteId { get; set; }
		public String Nombre { get; set; }
        public string Apellido { get; set; }
		public string FullName { get { return $"{Nombre}{ Apellido}".Trim(); } }
		public int Edad
		{
			get { return Birthday.HasValue ? DateTime.Now.Year - Birthday.Value.Date.Year : 0; }
		}
		public DateTime? Birthday { get; set; }
		public string Direccion { get; set; }
		public bool? Genero { get; set; }
		public string Telefono { get; set; }
		public string correo { get; set; }		
	}
}
