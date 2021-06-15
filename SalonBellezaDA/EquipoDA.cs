using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonBellezaBO;
using System.Data.Entity;

namespace SalonBellezaDA
{
public	class EquipoDA
	{
       SalonBellezaContext _context = null;

        public EquipoDA()
        {

        }

        public List<equipo> GetEquipo(equipo bo)
        {
            using (_context = new SalonBellezaContext())// aqui se indica lo que se quiere de la consulta
            {
                var query = _context.Equipos.Select(x => x);

                if (!String.IsNullOrEmpty(bo.Nombre))
                    query = query.Where(x => x.Nombre == bo.Nombre);

              

            
                return query.ToList();
            }
        }

        public equipo GetEquipo(int id)
        {
            using (_context = new SalonBellezaContext())
            {
                return _context.Equipos.FirstOrDefault(x => x.EquipoId == id) ?? new equipo();
            }
        }

        public equipo GetEquipo2(string nombre)
        {
            using (_context = new SalonBellezaContext())
            {
                return _context.Equipos.FirstOrDefault(x => x.Nombre == nombre) ?? new equipo();
            }
        }
        public int CreateEquipo(equipo bo)
        {
            using (_context = new SalonBellezaContext())
            {
                _context.Entry<equipo>(bo).State = EntityState.Added;//ponerse delete
                _context.SaveChanges();
            }

            return bo.EquipoId;
        }

        public int UpdateEquipo(int id, equipo bo)
        {
            var equipo = GetEquipo(id);


            if (equipo.EquipoId <= 0)
                return 0;

            using (_context = new SalonBellezaContext())
            {
                bo.EquipoId = equipo.EquipoId;

                _context.Entry<equipo>(bo).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return bo.EquipoId;
        }


        public int DeleteEquipo(int id)
        {
            var query = GetEquipo(id);

            if (query.EquipoId <= 0)
                return 0;

            using (_context = new SalonBellezaContext())
            {
                _context.Entry<equipo>(query).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            return 1;
        }






    }
}
