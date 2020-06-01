using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Poyecto_Tickets_DAL;
using Proyecto_Tickets_BLL;
using System.Data;

namespace Proyecto_Tickets.Ticket
{
    public partial class ticket_i : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                cargarDatos();
                cargarTipos();
                cargarClientes();
                cargarCategorias();
                cargarTabla();
                lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            
        }
        protected void btnAgregarTicket_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
            agregarTicket();
            ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('Ticket Agregado Exitosamente.')", true);
            }
            
        }

        

        protected void grdTickets_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Ticket/ticket_u.aspx?pID_Ticket=" + e.CommandArgument);//Redireccionar al usuario.
            }
            
        }
        #endregion

        #region Metodos

        public void agregarTicket()
        {
            Ticket_BLL ticketBLL = new Ticket_BLL();
            Poyecto_Tickets_DAL.Ticket ticket = new Poyecto_Tickets_DAL.Ticket();

            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];


            ticket.titulo = txtTitulo.Text;
            ticket.descripcion = txtDescripcion.Text;
            ticket.fecha_creacion = Convert.ToDateTime(txtFechaCreacion.Text);
            ticket.categoria = int.Parse(ddlCategoría.SelectedValue);
            ticket.tipo = int.Parse(ddlTipo.SelectedValue);
            ticket.ID_Usuario = usuario.ID_Usuario;
            ticket.ID_Asignado = int.Parse(ddlUsuario.SelectedValue);
            ticket.nivel_Soporte = usuario.nivel_soporte;
            ticket.status = int.Parse(ddlStatus.SelectedValue);
            ticket.solucion = " ";

            ticketBLL.agregarTicket(ticket);
            limpiarCampos();

            DataTable dtTicket = new DataTable();
            dtTicket = (DataTable)ViewState["tablaTicket"];
            dtTicket.Rows.Add(ticket.ID_Ticket, ticket.titulo, ticket.status);

            grdTickets.DataSource = dtTicket;
            grdTickets.DataBind();

            
            
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

        public void cargarClientes()
        {
            Cliente_BLL clienteBLL = new Cliente_BLL();
            List<Cliente> cliente = new List<Cliente>();


            cliente = clienteBLL.cargarClientes();

            ddlUsuario.DataSource = cliente;
            ddlUsuario.DataTextField = "nombre";
            ddlUsuario.DataValueField = "ID_Cliente";
            ddlUsuario.DataBind();

            ddlUsuario.Items.Insert(0, new ListItem("---- Seleccione Cliente ----", "0"));

        }

        public void cargarDatos()
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];

            string nivel = usuario.Nivel_Soporte1.Nombre;
            txtFechaCreacion.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtNivelSoporte.Text = nivel;
            ddlStatus.Items.Add(new ListItem("Desarrollo", "1"));
        }

        public void cargarTabla()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID_Ticket");
            dt.Columns.Add("titulo");
            dt.Columns.Add("status");

            ViewState["tablaTicket"] = dt; //Objeto temporal
        }

        public void limpiarCampos()
        {
            txtTitulo.Text = "";
            txtDescripcion.Text = "";
            ddlCategoría.SelectedIndex = 0;
            ddlTipo.SelectedIndex = 0;
            ddlUsuario.SelectedIndex = 0;

        }

        

        #endregion

        
    }
}