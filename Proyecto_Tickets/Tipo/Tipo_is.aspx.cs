using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Poyecto_Tickets_DAL;
using Proyecto_Tickets_BLL;
using System.Data;


namespace Proyecto_Tickets.Tipo
{
    public partial class Tipo_is : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grdCategoria.DataSource = CargarTipos();
            grdCategoria.DataBind();
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void btnAgregarTipo_Click(object sender, EventArgs e)
        {
            agregarTipo();
            ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('Categoría Agregado Exitosamente.')", true);
        }

        protected void grdCategoria_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar1")
            {
                Response.Redirect("~/Tipo/tipo_u.aspx?pID_Tipo=" + e.CommandArgument);//Redireccionar al usuario.
            }
        }


        public void agregarTipo()
        {
            Tipo_BLL tipoBLL = new Tipo_BLL();
            Poyecto_Tickets_DAL.Tipo tipo = new Poyecto_Tickets_DAL.Tipo();


            tipo.Nombre = txtNombre.Text;
           tipo.Descripcion = txtDescripcion.Text;

            tipoBLL.AgregarTipo(tipo);
            limpiarCampos();



        }

        public List<Poyecto_Tickets_DAL.Tipo> CargarTipos()
        {
            Tipo_BLL tipoBLL = new Tipo_BLL();
            List<Poyecto_Tickets_DAL.Tipo> tipo = new List<Poyecto_Tickets_DAL.Tipo>();

            tipo = tipoBLL.cargarTipos();
            return tipo;
        }

        public void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";


        }
    }
}