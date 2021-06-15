using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonBellezaBO;
using SalonBellezaDA;
using System.Data.Entity;

namespace SalonBellezaSRV
{
	public class EmpleadoSRV
	{

        public List<empleado> GetEmpleados(empleado bo)
        {
            return new EmpleadoDA().GetEmpleados(bo);
        }

        public empleado GetEmpleado(int id)
        {
            return new EmpleadoDA().GetEmpleado(id);
        }

        public int CreateEmpleado(empleado bo)
        {
            if (bo == null)
                return 0;

            if (bo.EmpleadoId != 0)
                return 0;

            return new EmpleadoDA().CreateEmpleado(bo);
        }

        public int UpdateEmpleado(int id, empleado bo)
        {
            if (id <= 0)
                return 0;

            return new EmpleadoDA().UpdateEmpleado(id, bo);
        }
        public int DeleteEmpleado(int id)
        {
            return new EmpleadoDA().DeleteEmpleado(id);
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
