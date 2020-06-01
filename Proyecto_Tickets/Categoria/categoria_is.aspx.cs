using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Poyecto_Tickets_DAL;
using Proyecto_Tickets_BLL;
using System.Data;

namespace Proyecto_Tickets.Categoria
{
    public partial class categoria_is : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            grdCategoria.DataSource = CargarCategorias();
            grdCategoria.DataBind();
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            agregarCategoria();
            ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Alta", "alert('Producto/Servicio Agregado Exitosamente.')", true);

        }

        protected void grdCategoria_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar1")
            {
                Response.Redirect("~/Categoria/categoria_u.aspx?pID_Categoria=" + e.CommandArgument);//Redireccionar al usuario.
            }
        }


        #endregion 

        public void agregarCategoria()
        {
            Categoria_BLL categoriaBLL = new Categoria_BLL();
            Poyecto_Tickets_DAL.Categoria categoria = new Poyecto_Tickets_DAL.Categoria();


            categoria.nombre = txtNombre.Text;
            categoria.descripcion = txtDescripcion.Text;

            categoriaBLL.AgregarCategoria(categoria);
            limpiarCampos();



        }

        public List<Poyecto_Tickets_DAL.Categoria> CargarCategorias()
        {
            Categoria_BLL categoriaBLL = new Categoria_BLL();
            List<Poyecto_Tickets_DAL.Categoria> categoria = new List<Poyecto_Tickets_DAL.Categoria>();

            categoria = categoriaBLL.cargarCategorias();
            return categoria;
        }
            

        public void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            

        }
    }
}