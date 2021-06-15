using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonBellezaBO;
using System.Data.Entity;

namespace SalonBellezaDA
{
	public class ServicioDA
	{
       SalonBellezaContext _context = null;//coneccion

        public ServicioDA()
        {

        }

        public List<Servicio> GetServicios(Servicio bo)
        {
            using (_context = new SalonBellezaContext())
            {
                var query = _context.Servicios.Select(x => x);

                if (!String.IsNullOrEmpty(bo.Nombre))
                    query = query.Where(x => x.Nombre == bo.Nombre);

                // if (!String.IsNullOrEmpty(bo.ServicioId))
                 //query = query.Where(x => x.ServicioId == bo.ServicioId);

                //if (bo.Age > 0)
                //    query = query.Where(x => x.Age == bo.Age);
                // if (bo.Genero.HasValue)
                //query = query.Where(x => x.Genero == bo.Genero.Value);

                //if (!String.IsNullOrEmpty(bo.Costo))
                 //query = query.Where(x => x.Costo == bo.Costo);

                //if (!String.IsNullOrEmpty(bo.correo))
                // query = query.Where(x => x.correo == bo.correo);

                //if (!String.IsNullOrEmpty(bo.Telefono))
                // query = query.Where(x => x.Telefono == bo.Telefono);

               // if (bo.Fecha.HasValue)
                   // query = query.Where(x => DbFunctions.TruncateTime(x.Fecha.Value) == DbFunctions.TruncateTime(bo.Fecha.Value));

               // if (bo.Hora.HasValue)
                  //  query = query.Where(x => DbFunctions.TruncateTime(x.Hora.Value) == DbFunctions.TruncateTime(bo.Fecha.Value));

                return query.ToList();
            }
        }

        public Servicio GetServicio(int id)
        {
            using (_context = new SalonBellezaContext())
            {
                return _context.Servicios.FirstOrDefault(x => x.ServicioId == id) ?? new Servicio();
            }
        }

        public int CreateServicio(Servicio bo)
        {
            using (_context = new SalonBellezaContext())
            {
                _context.Entry<Servicio>(bo).State = EntityState.Added;
                _context.SaveChanges();
            }

            return bo.ServicioId;
        }

        public int UpdateServicio(int id, Servicio bo)
        {
            var servicio = GetServicio(id);

            if (servicio.ServicioId <= 0)
                return 0;

            using (_context = new SalonBellezaContext())
            {
                bo.ServicioId = servicio.ServicioId;

                _context.Entry<Servicio>(bo).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return bo.ServicioId;
        }

      /*  public int Deleteservicio(int id)
        {
            var servicio = GetServicio(id);

            if (servicio.ServicioId <= 0)

                return false;

            using (_context = new SalonBellezaContext())
            {
                _context.Entry<Servicio>(servicio).State = EntityState.Deleted;//ponerse delete
                _context.SaveChanges();
            }

            return true;
        }*/
    }
}

