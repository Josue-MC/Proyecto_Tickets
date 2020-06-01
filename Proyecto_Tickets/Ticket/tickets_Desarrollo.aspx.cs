using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Tickets_BLL;
using Poyecto_Tickets_DAL;
using System.Data;

namespace Proyecto_Tickets.Ticket
{
    public partial class tickets_Desarrollo : System.Web.UI.Page
    {
        #region Metodos
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];


            int pNivel = usuario.nivel_soporte;
            string nivel = usuario.Nivel_Soporte1.Nombre;
            lblNivel.Text = nivel;
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void grdTickets_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];

            string rol = usuario.Rol1.Nombre;

            if (e.CommandName == "Editar1")
            {
                Response.Redirect("~/Ticket/ticket_u.aspx?pID_Ticket=" + e.CommandArgument);//Redireccionar al usuario.
            }
            else
            {
                if (rol == "Administrador")
                {
                    Response.Redirect("~/Ticket/ticket_d.aspx?pID_Ticket=" + e.CommandArgument);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('No cuenta con permisos para realizar esta operación.')", true);
                }
            }
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];
            int pNivel = usuario.nivel_soporte;
            int pEstado = 1;
            grdTickets.DataSource = CargarTicketsPorEstado(pNivel, pEstado);
            grdTickets.DataBind();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];
            int pNivel = usuario.nivel_soporte;

            int pID_Ticket = int.Parse(txtSearch.Text);
            int pEstado = 1;

            grdTickets.DataSource = CargarTicketsPorIDEstado(pNivel, pID_Ticket, pEstado);
            grdTickets.DataBind();
            }

            
        }

#endregion

        public List<object> CargarTicketsPorEstado(int pNivel, int pEstado)
        {
            Ticket_BLL ticketBLL = new Ticket_BLL();
            List<object> listTickets = new List<object>();


            listTickets = ticketBLL.CargarTicketsPorEstado(pNivel, pEstado);
            return listTickets;




        }

        public List<object> CargarTicketsPorIDEstado(int pNivel, int pID_Ticket, int pEstado)
        {
            Ticket_BLL ticketBLL = new Ticket_BLL();
            List<object> listTickets = new List<object>();


            listTickets = ticketBLL.CargarTicketsPorIDEstado(pNivel, pID_Ticket, pEstado);
            return listTickets;




        }
    }
}