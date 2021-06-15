using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonBellezaBO;
using System.Data.Entity;




namespace SalonBellezaDA
{
	public class EmpleadoDA
	{
        SalonBellezaContext _Context = null;

        public EmpleadoDA()
        {

        }

        public List<empleado> GetEmpleados(empleado bo)
        {
            using (_Context = new SalonBellezaContext())
            {
                var query = _Context.Empleados.Select(x => x);

                if (!String.IsNullOrEmpty(bo.Nombre))
                    query = query.Where(x => x.Nombre == bo.Nombre);

                if (!String.IsNullOrEmpty(bo.Apellido))
                    query = query.Where(x => x.Apellido == bo.Apellido);

                //if (bo.Age > 0)
                //    query = query.Where(x => x.Age == bo.Age);
                if (bo.Genero.HasValue)
                    query = query.Where(x => x.Genero == bo.Genero.Value);

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

        public empleado GetEmpleado(int id)
        {
            using (_Context = new SalonBellezaContext())
            {
                return _Context.Empleados.FirstOrDefault(x => x.EmpleadoId == id) ?? new empleado();
            }
        }

        public int CreateEmpleado(empleado bo)
        {
            using (_Context = new SalonBellezaContext())
            {
                _Context.Entry<empleado>(bo).State = EntityState.Added;
                _Context.SaveChanges();
            }

            return bo.EmpleadoId;
        }

        public int UpdateEmpleado(int id, empleado bo)
        {
            var empleado = GetEmpleado(id);

            if (empleado.EmpleadoId <= 0)
                return 0;

            using (_Context = new SalonBellezaContext())
            {
                bo.EmpleadoId = empleado.EmpleadoId;

                _Context.Entry<empleado>(bo).State = EntityState.Modified;
                _Context.SaveChanges();
            }
            return bo.EmpleadoId;
        }


        public int DeleteEmpleado(int id)
        {
            var query = GetEmpleado(id);

            if (query.EmpleadoId <= 0)
                return 0;

            using (_Context = new SalonBellezaContext())
            {
                _Context.Entry<empleado>(query).State = EntityState.Deleted;
                _Context.SaveChanges();
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
