using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonBellezaBO;
using SalonBellezaDA;

namespace SalonBellezaSRV

{
	public class CitaSRV
	{
        public List<cita> GetCita(cita bo)
        {
            return new CitaDA().GetCita(bo);
        }

        public cita GetCita(int id)
        {
            return new CitaDA().GetCita(id);
        }

        public int CreateCita(cita bo)
        {
            if (bo == null)
                return 0;

            if (bo.CitaId != 0)
                return 0;

            return new CitaDA().CreateCita(bo);
        }

        public int UpdateCita(int id, cita bo)
        {
            if (id <= 0)
                return 0;

            return new CitaDA().UpdateCita(id, bo);
        }

        public int DeleteCita(int id)
        {
            return new CitaDA().DeleteCita(id);
        }

        /* public void LoadData()
         {
             var dao = new ClienteDA();
             var lstTemp = dao.LoadData();

             var bo = new cliente();
             foreach (var Cliente in lstTemp)
             {
                 bo.correo = Cliente.correo;
                 var lst = dao.GetClientes(bo);
                 if (!lst.Any())
                     dao.CreateCliente(Cliente);
                 //break;
             }
         }*/






    }
}
