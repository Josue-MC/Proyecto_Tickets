using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_Tickets_BLL;
using Poyecto_Tickets_DAL;

namespace Proyecto_Tickets.Clientes
{
    public partial class cliente_s : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void grdClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string pCorreo = txtSearch.Text;

                grdClientes.DataSource = cargarClientePorCorreo(pCorreo);
                grdClientes.DataBind();
            }
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            grdClientes.DataSource = cargarClientes();
            grdClientes.DataBind();
        }


        #region métodos

        public List<Cliente> cargarClientes()
        {
            Cliente_BLL clientebll = new Cliente_BLL();
            List<Cliente> listClientes = new List<Cliente>();

            listClientes = clientebll.cargarClientes();

            return listClientes;

        }

        public List<Cliente> cargarClientePorCorreo(string pCorreo)
        {
            Cliente_BLL clientebll = new Cliente_BLL();
            List<Cliente> listClientes = new List<Cliente>();

            listClientes = clientebll.cargarClientePorCorreo(pCorreo);

            return listClientes;
        }


        #endregion

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = (Usuario)Session["Usuario"];

            string rol = usuario.Rol1.Nombre;



            if (rol == "Administrador")
            {
                Response.Redirect("~Clientes/cliente_i.aspx");

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('No cuenta con permisos para realizar esta operación.')", true);

            }
        }
    }
}