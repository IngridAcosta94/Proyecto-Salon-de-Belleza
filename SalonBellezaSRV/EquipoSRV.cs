using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonBellezaBO;
using SalonBellezaDA;


namespace SalonBellezaSRV
{
	class EquipoSRV
	{
        public List<equipo> GetEquipos(equipo bo)
        {
            return new EquipoDA().GetEquipo(bo);
        }

        public equipo GetEquipo(int id)
        {
            return new EquipoDA().GetEquipo(id);
        }
        public equipo GetEquipo2(String Nombre)
        {
            return new EquipoDA().GetEquipo2(Nombre);
        }

        public int CreateEquipo(equipo bo)
        {
            if (bo == null)
                return 0;

            if (bo.EquipoId != 0)
                return 0;

            return new EquipoDA().CreateEquipo(bo);
        }

        public int UpdateEquipo(int id, equipo bo)
        {
            if (id <= 0)
                return 0;

            return new EquipoDA().UpdateEquipo(id, bo);
        }



        public int DeleteEquipo(int id)
        {
            return new EquipoDA().DeleteEquipo(id);
        }

    }
}
