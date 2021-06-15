using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonBellezaBO;
using System.Data.Entity;


namespace SalonBellezaDA
{
    public	class CitaDA
    {
        SalonBellezaContext _context = null;//coneccion

        public CitaDA()
        {

        }

        public List<cita> GetCita(cita bo)
        {
            using (_context = new SalonBellezaContext())
            {
                var query = _context.Citas.Select(x => x);

                if (!String.IsNullOrEmpty(bo.Estatus))
                    query = query.Where(x => x.Estatus == bo.Estatus);

                if (bo.FechaHora.HasValue)
                    query = query.Where(x => DbFunctions.TruncateTime(x.FechaHora.Value) == DbFunctions.TruncateTime(bo.FechaHora.Value));

                return query.ToList();
            }
        }

        public cita GetCita(int id)
        {
            using (_context = new SalonBellezaContext())
            {
                return _context.Citas.FirstOrDefault(x => x.CitaId == id) ?? new cita();
            }
        }

        public int CreateCita(cita bo)
        {
            using (_context = new SalonBellezaContext())
            {
                _context.Entry<cita>(bo).State = EntityState.Added;
                _context.SaveChanges();
            }

            return bo.CitaId;
        }

        public int UpdateCita(int id, cita bo)
        {
            var cita = GetCita(id);

            if (cita.CitaId <= 0)
                return 0;

            using (_context = new SalonBellezaContext())
            {
                bo.CitaId = cita.CitaId;

                _context.Entry<cita>(bo).State = EntityState.Modified;
                _context.SaveChanges();
            }
            return bo.CitaId;
        }

        public int DeleteCita(int id)
        {
            var query = GetCita(id);

            if (query.CitaId <= 0)
                return 0;

            using (_context = new SalonBellezaContext())
            {
                _context.Entry<cita>(query).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            return 1;
        }





    }

















}
