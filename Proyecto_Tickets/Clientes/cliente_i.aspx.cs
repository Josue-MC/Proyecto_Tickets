using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Poyecto_Tickets_DAL;
using Proyecto_Tickets_BLL;

namespace Proyecto_Tickets.Clientes
{
    public partial class cliente_i : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            cargarGenero();
            }
            
        }

        protected void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                agregarCliente();
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('Cliente Agregado Exitosamente.')", true);
            }
            

        }

        public void agregarCliente()
        {
            Cliente cliente = new Cliente();
            Cliente_BLL clienteBll = new Cliente_BLL();

            cliente.nombre = txtNombre.Text;
            cliente.apellidos = txtApellidos.Text;
            cliente.email = txtCorreo.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.sexo = ddlSexo.SelectedValue;

            try
            {
                clienteBll.agregarCliente(cliente);
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('" + ex.Message + "')", true);
            }
            
        }



        public void cargarGenero()
        {
            ddlSexo.Items.Insert(0, new ListItem("----  Género ----", "0"));
            ddlSexo.Items.Insert(1, new ListItem("Masculino", "M"));
            ddlSexo.Items.Insert(2, new ListItem("Femenino", "F"));
        }
    }
}