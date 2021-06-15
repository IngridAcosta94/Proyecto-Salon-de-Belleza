using System;

namespace SalonBellezaBO
{
	public class cita
	{
		public int CitaId { get; set; }
		//public DateTime? Hora { get; set; }// se le pone ? y se usa el hasvalue y value
        public DateTime? FechaHora { get; set; }// se le pone ? 
		public string Estatus { get; set; }
		public int ClienteId { get; set; }
		public cliente cliente { get; set; }
		public int ServicioId { get; set; }
		public Servicio Servicio { get; set; }
		///asociar conn cliente 
	}
}
