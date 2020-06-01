using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_Tickets_DAL
{
    public class Tipo_DAL
    {
        sgticketsEntities modelo;

        public Tipo_DAL()
        {
            modelo = new sgticketsEntities();
        }

        public List<Tipo> cargarTipos()
        {
            var tipo = from mtipo in modelo.Tipo
                            select mtipo;

            return tipo.ToList();


        }

        public void AgregarTipo(Tipo tipo)
        {
            modelo.Tipo.Add(tipo);
            modelo.SaveChanges();
        }

        public Tipo cargarTiposPorID(int pID_Tipo)
        {
            var tipo = (from mtipo in modelo.Tipo
                             where mtipo.ID_Tipo == pID_Tipo
                             select mtipo).FirstOrDefault();

            return tipo;


        }

        public void editarTipo(Tipo pTipo)
        {
            var tipo = (from mtipo in modelo.Tipo
                             where mtipo.ID_Tipo == pTipo.ID_Tipo
                             select mtipo).FirstOrDefault();

            tipo.Nombre = pTipo.Nombre;
            tipo.Descripcion = pTipo.Descripcion;

            modelo.SaveChanges();
        }

        public int cargarTiposSite()
        {
            var tipo = (from mtipo in modelo.Tipo
                        select mtipo).Count();

            return tipo;
        }

        public string cargarTipoPorId(int pID_Tipo)
        {
            var tipo = (from mtipo in modelo.Tipo
                        where mtipo.ID_Tipo == pID_Tipo
                        select mtipo.Nombre).FirstOrDefault();

            return tipo;
        }
    }
}
