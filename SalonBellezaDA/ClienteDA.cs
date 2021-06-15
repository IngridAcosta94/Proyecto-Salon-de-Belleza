using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonBellezaBO;
using System.Data.Entity;
using System.IO;

namespace SalonBellezaDA
{
	public class ClienteDA
	{


        SalonBellezaContext _context = null;

        public ClienteDA()
        {

        }

        public List<cliente> GetClientes(cliente bo)
        {
            using (_context = new SalonBellezaContext())// aqui se indica lo que se quiere de la consulta
            {
                var query = _context.Clientes.Select(x => x);

                if (!String.IsNullOrEmpty(bo.Nombre))
                    query = query.Where(x => x.Nombre == bo.Nombre);

                if (!String.IsNullOrEmpty(bo.Apellido))
                    query = query.Where(x => x.Apellido == bo.Apellido);

                //if (bo.Age > 0)
                // query = query.Where(x => x.Age == bo.Age);

                if (bo.Genero.HasValue)
                    query = query.Where(x => x.Genero == bo.Genero.Value);


                //if (!String.IsNullOrEmpty(bo.Genero))
                //query = query.Where(x => x.Genero == bo.Genero);

                if (!String.IsNullOrEmpty(bo.Direccion))
                    query = query.Where(x => x.Direccion == bo.Direccion);

                if (!String.IsNullOrEmpty(bo.correo))
                    query = query.Where(x => x.correo == bo.correo);

                if (!String.IsNullOrEmpty(bo.Telefono))
                    query = query.Where(x => x.Telefono == bo.Telefono);

                if (bo.Birthday.HasValue)
                    query = query.Where(x => DbFunctions.TruncateTime(x.Birthday.Value) == DbFunctions.TruncateTime(bo.Birthday.Value));

                return query.ToList();
            }
        }

        public cliente GetCliente(int id)
        {
            using (_context = new SalonBellezaContext())
            {
                return _context.Clientes.FirstOrDefault(x => x.ClienteId == id) ?? new cliente();
            }
        }

        public cliente GetCliente2(string nombre)
        {
            using (_context = new SalonBellezaContext())
            {
                return _context.Clientes.FirstOrDefault(x => x.Nombre == nombre) ?? new cliente();
            }
        }
        public int CreateCliente(cliente bo)
        {
            using (_context = new SalonBellezaContext())
            {
                _context.Entry<cliente>(bo).State = EntityState.Added;//ponerse delete
                _context.SaveChanges();
            }

            return bo.ClienteId;
        }

        public int UpdateCliente(int id, cliente bo)
        {
            var cliente = GetCliente(id);


            if (cliente.ClienteId <= 0)
                return 0;

            using (_context = new SalonBellezaContext())
            {
                bo.ClienteId = cliente.ClienteId;

                _context.Entry<cliente>(bo).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return bo.ClienteId;
        }

         public int DeleteCliente(int id)
        {
            var query = GetCliente(id);

            if (query.ClienteId <= 0)
                return 0;

            using (_context = new SalonBellezaContext())
            {
                _context.Entry<cliente>(query).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            return 1;
        }


        /* public List<cliente> LoadData()
         {
             // obtenemos la ruta de ejecución
             var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)?.Remove(0, 6) + "/";

             // Leemos el archivo
             var json = File.ReadAllText(path + @"/Json.practicautm.txt");

             // Convertimos el texto en objetos mediante newtonsoft
             var lstPersons = JsonConvert.DeserializeObject<List<cliente>>(json);

             // retornamos la lista resultante
             return lstPersons;
         }*/



















    }
}
