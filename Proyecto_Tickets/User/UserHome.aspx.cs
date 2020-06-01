using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Poyecto_Tickets_DAL;
using Proyecto_Tickets_BLL;

namespace Proyecto_Tickets.User
{
    public partial class UserView : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblTickets.Text = cargarTicketSite().ToString();
            lblCategoria.Text = cargarCategoriasSite().ToString();
            lblTipo.Text = cargarTiposSite().ToString();
            lblCliente.Text = cargarClienteSite().ToString();
        }

        #endregion

        #region
        public void cargarDatos()
        {
            Usuario user = new Usuario();
            user = (Usuario)Session["Usuario"];

            string email = user.email;
            txtEmail.Text = email;

            string nombre = user.nombre;
            txtNombre.Text = nombre;

            string apellidos = user.apellidos;
            txtApellidos.Text = apellidos;

            string rol = user.Nivel_Soporte1.Nombre;
            lblNivelSoporte.Text = rol;
        }

        public int cargarTicketSite()
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];
            Ticket_BLL ticket = new Ticket_BLL();

            int pNivel = usuario.nivel_soporte;

            return ticket.cargarTicketSite(pNivel);
        }

        public int cargarCategoriasSite()
        {
            Categoria_BLL cate = new Categoria_BLL();
            return cate.cargarCategoriasSite();
        }

        public int cargarTiposSite()
        {
            Tipo_BLL tipobll = new Tipo_BLL();
            return tipobll.cargarTiposSite();
        }

        public int cargarClienteSite()
        {
            Cliente_BLL clientebll = new Cliente_BLL();
            return clientebll.cargarClienteSite();
        }
        #endregion
    }
}