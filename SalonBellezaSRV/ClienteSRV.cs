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
	public class ClienteSRV
	{
        public List<cliente> GetClientes(cliente bo)
        {
            return new ClienteDA().GetClientes(bo);
        }

        public cliente GetCliente (int id)
        {
            return new ClienteDA().GetCliente(id);
        }
        public cliente GetCliente2(String Nombre)
        {
            return new ClienteDA().GetCliente2(Nombre);
        }

        public int CreateCliente(cliente bo)
        {
            if (bo == null)
                return 0;

            if (bo.ClienteId != 0)
                return 0;

            return new ClienteDA().CreateCliente(bo);
        }

        public int UpdateCliente(int id, cliente bo)
        {
            if (id <= 0)
                return 0;

            return new ClienteDA().UpdateCliente(id,bo);
        }



        public int DeleteCliente(int id)
        {
            return new ClienteDA().DeleteCliente(id);
        }


        /* public int DeleteCliente(cliente bo)
         {
             if (bo == null)
                 return 0;

             if (bo.ClienteId != 0)
                 return 0;

             return new ClienteDA().DeleteCliente(bo);
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
