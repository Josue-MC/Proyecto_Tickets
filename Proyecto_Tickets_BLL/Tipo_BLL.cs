using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poyecto_Tickets_DAL;

namespace Proyecto_Tickets_BLL
{
    public class Tipo_BLL
    {
        public List<Tipo> cargarTipos()
        {
            Tipo_DAL tipoDAL = new Tipo_DAL();
            return tipoDAL.cargarTipos();
        }

        public Tipo cargarTiposPorID(int pID_Tipo)
        {
            Tipo_DAL tipo = new Tipo_DAL();
            return tipo.cargarTiposPorID(pID_Tipo);
        }

        public void AgregarTipo(Tipo tipo)
        {
            Tipo_DAL tipoDAL = new Tipo_DAL();
            tipoDAL.AgregarTipo(tipo);
        }

        public void EditarTipo(Tipo pTipo)
        {
            Tipo_DAL tipoDAL = new Tipo_DAL();
            tipoDAL.editarTipo(pTipo);
        }

        public int cargarTiposSite()
        {
            Tipo_DAL tipoDAL = new Tipo_DAL();
            return tipoDAL.cargarTiposSite();
        }

        public string cargarTipoPorId(int pID_Tipo)
        {
            Tipo_DAL tipoDAL = new Tipo_DAL();
            return tipoDAL.cargarTipoPorId(pID_Tipo);
        }
    }
}
