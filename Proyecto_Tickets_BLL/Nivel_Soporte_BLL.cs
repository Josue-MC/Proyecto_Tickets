using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poyecto_Tickets_DAL;

namespace Proyecto_Tickets_BLL
{
    public class Nivel_Soporte_BLL
    {
        public List<Nivel_Soporte> cargarNivel()
        {
            Nivel_Soporte_DAL nivel = new Nivel_Soporte_DAL();
            return nivel.cargarNivel();
        }

        public int cargarNiveles()
        {
            Nivel_Soporte_DAL nivel = new Nivel_Soporte_DAL();
            return nivel.cargarNiveles();
        }

        public string cargarNivelNombre(int ID_Nivel)
        {
            Nivel_Soporte_DAL nivel = new Nivel_Soporte_DAL();
            return nivel.cargarNivelNombre(ID_Nivel);
        }

    }
}
