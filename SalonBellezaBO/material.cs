using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonBellezaBO
{
	public class material
	{
		public int MaterialId { get; set; }
		public string Nombre { get; set; }

		public virtual ICollection<TipoServicio> TipoServicios { get; set; } //PROPIEDAD para la asosiacion de MM

		public material()//contructor Para la asociasion de MM
		{
			this.TipoServicios = new HashSet<TipoServicio>();
		}



	}
}
