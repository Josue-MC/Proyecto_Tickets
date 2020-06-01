using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_Tickets_DAL
{
    public class Nivel_Soporte_DAL
    {
        sgticketsEntities modelo;

        public Nivel_Soporte_DAL()
        {
            modelo = new sgticketsEntities();
        }

        public List<Nivel_Soporte> cargarNivel()
        {
            var nivel = from mnivel in modelo.Nivel_Soporte
                        select mnivel;

            return nivel.ToList();


        }

        public int cargarNiveles()
        {
            var nivel = (from mnivel in modelo.Nivel_Soporte
                         select mnivel).Count();

            return nivel;
        }

        public string cargarNivelNombre(int ID_Nivel)
        {
            var nivel = (from mnivel in modelo.Nivel_Soporte
                         where mnivel.ID_Nivel == ID_Nivel
                         select mnivel.Nombre).FirstOrDefault();

            return nivel;
        }
    }
}
