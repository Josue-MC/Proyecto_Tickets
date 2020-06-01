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
    public partial class ticket_s : System.Web.UI.Page
    {
        #region Eventos



        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];

            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");

            int pNivel = usuario.nivel_soporte;
            string nivel = usuario.Nivel_Soporte1.Nombre;
            lblNivel.Text = nivel;

            

            if (!IsPostBack)
            {
               
                cargarCategorias();
                cargarStatus();
                cargarTipos();
                cargarTabla();
            }
            else
            {
                
                
               
            }
            

           

            
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

        protected void btnconsultar_Click(object sender, EventArgs e)
        {
            


        }

       protected void btnCargar_Click(object sender, EventArgs e)
        {   
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];
            int pNivel = usuario.nivel_soporte;
            grdTickets.DataSource = CargarTicketsPorNivel(pNivel);
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

                    grdTickets.DataSource = CargarTicketsPorID(pNivel, pID_Ticket);
                    grdTickets.DataBind();
            }
            
        }
        #endregion


        public List<object> CargarTicketsPorNivel(int pNivel)
        {
            Ticket_BLL ticketBLL = new Ticket_BLL();
            List<object> listTickets = new List<object>();

            
            listTickets = ticketBLL.CargarTicketsPorNivel(pNivel);
            return listTickets;
           

            

        }

        public List<object> CargarTicketsPorID(int pNivel, int pID_Ticket)
        {
            Ticket_BLL ticketBLL = new Ticket_BLL();
            List<object> listTickets = new List<object>();


            listTickets = ticketBLL.CargarTicketsPorID(pNivel, pID_Ticket);
            return listTickets;




        }

        public List<object> CargarTicketsPorEstados(int pNivel, int pStatus, int pTipo, int pCategoria)
        {
            Ticket_BLL ticketBLL = new Ticket_BLL();
            List<object> listTickets = new List<object>();


            listTickets = ticketBLL.CargarTicketsPorEstados(pNivel, pStatus, pTipo, pCategoria);
            return listTickets;




        }

        public void cargarCategorias()
        {
            Categoria_BLL categoriaBLL = new Categoria_BLL();
            List<Poyecto_Tickets_DAL.Categoria> categoria = new List<Poyecto_Tickets_DAL.Categoria>();



            categoria = categoriaBLL.cargarCategorias();

            ddlCategoría.DataSource = categoria;
            ddlCategoría.DataTextField = "nombre";
            ddlCategoría.DataValueField = "ID_Categoria";
            ddlCategoría.DataBind();

            ddlCategoría.Items.Insert(0, new ListItem("----  Producto/Servicio ----", "0"));

        }

        public void cargarTipos()
        {
            Tipo_BLL tipoBLL = new Tipo_BLL();
            List<Poyecto_Tickets_DAL.Tipo> tipo = new List<Poyecto_Tickets_DAL.Tipo>();


            tipo = tipoBLL.cargarTipos();

            ddlTipo.DataSource = tipo;
            ddlTipo.DataTextField = "Nombre";
            ddlTipo.DataValueField = "ID_Tipo";
            ddlTipo.DataBind();

            ddlTipo.Items.Insert(0, new ListItem("---- Seleccione Categoría ----", "0"));

        }

        public void cargarStatus()
        {
            Status_BLL statusBLL = new Status_BLL();
            List<Status> status = new List<Status>();

            status = statusBLL.cargarStatus();

            ddlStatus.DataSource = status;
            ddlStatus.DataTextField = "Nombre";
            ddlStatus.DataValueField = "ID_Status";
            ddlStatus.DataBind();

            ddlStatus.Items.Insert(0, new ListItem("---- Seleccione Estado ----", "7"));
        }

        public void cargarTabla()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("pStatus");
            dt.Columns.Add("pTipo");
            dt.Columns.Add("pCategoria");

            ViewState["tablaConsulta"] = dt; //Objeto temporal
        }

        
    }


}