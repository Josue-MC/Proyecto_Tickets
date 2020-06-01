using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Poyecto_Tickets_DAL;
using Proyecto_Tickets_BLL;

namespace Proyecto_Tickets.Ticket
{
    public partial class Ticket_u : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int ID_Ticket = int.Parse(Request.QueryString["pID_Ticket"]);
                //lblID_Ticket.Text = ID_Ticket.ToString();
                cargarTicket(ID_Ticket);

                lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");

                if (ddlStatus.SelectedItem.Value == "2" || ddlStatus.SelectedItem.Value == "3")
                {
                    txtTitulo.Enabled = false;
                    txtDescripcion.Enabled = false;
                    ddlCategoría.Enabled = false;
                    ddlUsuario.Enabled = false;
                    ddlStatus.Enabled = false;
                    ddlTipo.Enabled = false;
                    txtFechaCreacion.Enabled = false;
                    ddlNivel.Enabled = false;
                    txtSolución.Enabled = false;


                }
            }

            if (ddlStatus.SelectedItem.Value == "1" || ddlStatus.SelectedItem.Value == "3")
            {
                txtSolución.Enabled = false;
            }
            else if (ddlStatus.SelectedItem.Value == "2")
            {
                ddlStatus.Enabled = false;
                ddlNivel.Enabled = false;
                txtSolución.Enabled = true;
            }

            
        }

        protected void btnEditarTicket_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                editarTicket();
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('Ticket editado Exitosamente.')", true);
            }
            
        }

        
        #endregion

        public void editarTicket()
        {
            Ticket_BLL ticketBLL = new Ticket_BLL();
            Poyecto_Tickets_DAL.Ticket ticket = new Poyecto_Tickets_DAL.Ticket();

            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];

            int ID_Usuario = usuario.ID_Usuario;

            string nivel = usuario.nivel_soporte.ToString();

            ticket.ID_Ticket = int.Parse(lblID_Ticket.Text);
            ticket.titulo = txtTitulo.Text;
            ticket.descripcion = txtDescripcion.Text;
            ticket.fecha_creacion = Convert.ToDateTime(txtFechaCreacion.Text);
            ticket.categoria = int.Parse(ddlCategoría.SelectedValue);
            ticket.tipo = int.Parse(ddlTipo.SelectedValue);
            ticket.ID_Asignado = int.Parse(ddlUsuario.SelectedValue);
            ticket.nivel_Soporte = int.Parse(ddlNivel.SelectedValue);
            ticket.status = int.Parse(ddlStatus.SelectedValue);

            if (FechaTermino())
            {
                DateTime date = DateTime.Today;

                ticket.fecha_termino = date;
                ticket.solucion = txtSolución.Text;
            }

            if (ddlNivel.SelectedItem.Value != nivel)
            {
                ticket.ID_Usuario = 2;
            }
            else
            {
                ticket.ID_Usuario = ID_Usuario;
            }

            try
            {
                ticketBLL.editarTicket(ticket);
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('" + ex.Message + "')", true);
            }
            
        }

        public void cargarTicket(int ID_Ticket)
        {
            Ticket_BLL ticket_BLL = new Ticket_BLL();
            Poyecto_Tickets_DAL.Ticket ticket = new Poyecto_Tickets_DAL.Ticket();

            ticket = ticket_BLL.cargarTicket(ID_Ticket);

            lblID_Ticket.Text = ticket.ID_Ticket.ToString();
            txtTitulo.Text = ticket.titulo;
            txtDescripcion.Text = ticket.descripcion;
            txtFechaCreacion.Text = ((ticket.fecha_creacion).ToShortDateString()).ToString();

            cargarCategorias();
            ddlCategoría.SelectedValue = ticket.categoria.ToString();

            cargarTipos();
            ddlTipo.SelectedValue = ticket.tipo.ToString();

            cargarClientes();
            ddlUsuario.SelectedValue = ticket.ID_Asignado.ToString();

            cargarNivel();
            ddlNivel.SelectedValue = ticket.nivel_Soporte.ToString();

            cargarStatus();
            ddlStatus.SelectedValue = ticket.status.ToString();
            txtSolución.Text = ticket.solucion;
            

        }

        public void cargarNivel()
        {
            Nivel_Soporte_BLL nivelBLL = new Nivel_Soporte_BLL();
            List<Nivel_Soporte> nivel = new List<Nivel_Soporte>();

            nivel = nivelBLL.cargarNivel();

            ddlNivel.DataSource = nivel;
            ddlNivel.DataTextField = "Nombre";
            ddlNivel.DataValueField = "ID_Nivel";
            ddlNivel.DataBind();

            ddlNivel.Items.Insert(0, new ListItem("----  Seleccione Nivel ----", "0"));

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

            ddlStatus.Items.Insert(0, new ListItem("---- Seleccione Estado ----", "0"));
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

        
        public bool FechaTermino()
        {
            bool indicador;
            indicador = false;
            if (ddlStatus.SelectedItem.Value == "2" || ddlStatus.SelectedItem.Value == "3")
            {
                indicador = true;
                
                
            }
            else if (ddlStatus.SelectedItem.Value == "1")
            {
                indicador = false;
                
                
            }
            return indicador;
        }

        
    }
}