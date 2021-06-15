using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonBellezaBO;
using SalonBellezaDA;

namespace SalonBellezaSRV
{
	public class ServicioSRV
	{
        public List<Servicio> GetServicios(Servicio bo)
        {
            return new ServicioDA().GetServicios (bo);
        }

        public Servicio GetServicio(int id)
        {
            return new ServicioDA().GetServicio(id);
        }

        public int CreateServicio(Servicio bo)
        {
            if (bo == null)
                return 0;

            if (bo.ServicioId != 0)
                return 0;

            return new ServicioDA().CreateServicio(bo);
        }

        public int UpdateServicio(int id, Servicio bo)
        {
            if (id <= 0)
                return 0;

            return new ServicioDA().UpdateServicio(id, bo);
        }

       /* public void LoadData()
        {// no se para que es!!!
            var dao = new ServicioDA();
            var lstTemp = dao.LoadData();

            var bo = new Servicio();
            foreach (var servicio in lstTemp)
            {
                bo.Email = servicio.Email;
                var lst = dao.GetServiciobo);
                if (!lst.Any())
                    dao.CreateServicio(servicio);
                //break;
            }
        }*/
    }
}
