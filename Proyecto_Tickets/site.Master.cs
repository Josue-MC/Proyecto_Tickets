using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Poyecto_Tickets_DAL;
using Proyecto_Tickets_BLL;

namespace Proyecto_Tickets
{
    public partial class site : System.Web.UI.MasterPage
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        #endregion

        #region Metodos

        public void cargarDatos()
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];

            string nombre = usuario.nombre;
            string rol = usuario.Rol1.Nombre;
            string nivel = usuario.Nivel_Soporte1.Nombre;
            

            lblUserName.Text = nombre;
            LblUserName2.Text = nombre;
            lblUserName3.Text = nombre;
            lblRol1.Text = rol;
            lblRol.Text = nivel;
        }

        public int cargarTicketSite()
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];
            Ticket_BLL ticket = new Ticket_BLL();

            int pNivel = usuario.nivel_soporte;

            return ticket.cargarTicketSite(pNivel);
        }

        #endregion

    }
}