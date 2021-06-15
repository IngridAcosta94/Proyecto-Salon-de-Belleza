using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonBellezaBO;
using System.Data.Entity;

namespace SalonBellezaDA
{
	public class MaterialDA
	{

        SalonBellezaContext _context = null;

        public MaterialDA()
        {

        }

        public List<material> GetMaterial(material bo)
        {
            using (_context = new SalonBellezaContext())// aqui se indica lo que se quiere de la consulta
            {
                var query = _context.Materiales.Select(x => x);

                if (!String.IsNullOrEmpty(bo.Nombre))
                    query = query.Where(x => x.Nombre == bo.Nombre);

                return query.ToList();
            }
        }

        public material GetMaterail(int id)
        {
            using (_context = new SalonBellezaContext())
            {
                return _context.Materiales.FirstOrDefault(x => x.MaterialId == id) ?? new material();
            }
        }

        public material GetMaterial2(string nombre)
        {
            using (_context = new SalonBellezaContext())
            {
                return _context.Materiales.FirstOrDefault(x => x.Nombre == nombre) ?? new material();
            }
        }
        public int CreateMaterial(material bo)
        {
            using (_context = new SalonBellezaContext())
            {
                _context.Entry<material>(bo).State = EntityState.Added;//ponerse delete
                _context.SaveChanges();
            }

            return bo.MaterialId;
        }

       /* public int UpdateMaterial(int id, material bo)
        {
            var material = GetMaterial (id);


            if (material.MaterialId <= 0)
                return 0;

            using (_context = new SalonBellezaContext())
            {
                bo.MaterialId = material.MaterialId;

                _context.Entry<material>(bo).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return bo.MaterialId;
        }*/





        /*public int DeleteMaterial(int id)
        {
            var query = GetMaterial(id);

            if (query.MaterialId <= 0)
                return 0;

            using (_context = new SalonBellezaContext())
            {
                _context.Entry<material>(query).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            return 1;
        }*/
    }
}
